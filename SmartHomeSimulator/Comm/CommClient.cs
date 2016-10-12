using System.Threading;
using System.Net.Sockets;
using SmartHomeSimulator.Util;
using SmartHomeSimulator.Log;

namespace SmartHomeSimulator.Comm
{
    public class CommClient
    {
        private TcpClient tcpClient;
        private bool keepRunning = false;
        private Thread readingThread = null;
        NetworkStream stream = null;

        public event ClientStoppedEventHandler ClientStopped;

        public CommClient(TcpClient tcpClient)
        {            
            this.tcpClient = tcpClient;
            stream = tcpClient.GetStream();

            readingThread = new Thread(new ThreadStart(run));
            readingThread.Start();
        }

        private void run()
        {
            keepRunning = true;

            while (keepRunning)
            {
                Thread.Sleep(Constants.ShortWait);
                
                int length = tcpClient.Available;
                if (length > 0)
                {
                    byte[] buffer = new byte[length];
                    stream.Read(buffer, 0, length);

                    string strPacket = Utility.GetString(buffer);

                    handlePacket(strPacket);
                }

                keepRunning = !ProactiveDisconnected;
            }

            keepRunning = false;

            //notify local server
            if (ClientStopped != null)
                ClientStopped(this);
        }

        private void handlePacket(string strPacket)
        {
            try
            {
                LogManager.LogMessage(string.Format("Incomming packet : {0}", strPacket));

                ProtocolPacket packet = ProtocolPacket.Parse(strPacket);
                ProtocolPacket result = ProtocolManager.Instance.ProcessRequestPacket(packet);

                string strResponse = result.ToString();
                if (stream.CanWrite)
                { 
                    byte[] buffer = Utility.GetBytes(strResponse);
                    stream.Write(buffer, 0, buffer.Length);
                    stream.Flush();
                }

                LogManager.LogMessage(string.Format("Outgoing packet : {0}", strResponse));
            }
            catch
            {
                LogManager.LogMessage("Result: An error was encountered while handling the packet.");
            }
        }

        public bool ProactiveDisconnected
        {
            get
            {
                try
                {
                    if (!tcpClient.Connected)
                        return true;
                    // Detect if client disconnected
                    if (tcpClient.Client.Poll(0, SelectMode.SelectRead))
                    {
                        byte[] buff = new byte[1];
                        if (tcpClient.Client.Receive(buff, SocketFlags.Peek) == 0)
                        {
                            // Client disconnected
                            return true;
                        }
                    }
                }
                catch
                {
                    return true;
                }

                return false;
            }
        }

        internal void Stop()
        {
            if (!keepRunning)
                return;

            this.keepRunning = false;

            if (readingThread != null)
                readingThread.Abort();
        }
    }
}
