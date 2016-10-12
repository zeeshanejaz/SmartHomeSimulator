using System.Collections.Generic;
using System.Net;
using System.Net.Sockets;
using System.Threading;

namespace SmartHomeSimulator.Comm
{
    public class CommServer
    {
        private TcpListener listenerSocket;
        private bool started = false;
        private Thread listeningThread = null;
        private List<CommClient> clients = new List<CommClient>();
        public void Start()
        {
            if (started)
            {
                Stop();
            }
            
            listeningThread = new Thread(new ThreadStart(run));
            listeningThread.Start();
        }

        private void run()
        {
            listenerSocket = new TcpListener(IPAddress.Any, Constants.ListeningPort);

            started = true;

            listenerSocket.Start();

            try
            {
                while (started)
                {
                    Thread.Sleep(Constants.LongWait);
                    if (listenerSocket == null)
                        break;

                    if (listenerSocket != null && listenerSocket.Pending())
                    {
                        lock (clients)
                        {
                            CommClient newClient = new CommClient(listenerSocket.AcceptTcpClient());
                            newClient.ClientStopped += newClient_ClientStopped;
                            this.clients.Add(newClient);
                        }
                    }
                }
            }
            catch { Stop(); }
        }

        void newClient_ClientStopped(CommClient source)
        {
            lock (clients)
            {
                clients.Remove(source);
            }            
        }

        public void Stop()
        {
            if (!started)
                return;

            started = false;

            if (listenerSocket != null)
                listenerSocket.Stop();

            if (listeningThread != null)
                listeningThread.Abort();

            lock (clients)
            {
                foreach (CommClient client in clients)
                {
                    client.Stop();
                }

                clients.Clear();
            }
        }

        public bool HasClients
        {
            get
            {
                lock (clients)
                {
                    return (clients.Count > 0);
                }
            }
        }
    }
}
