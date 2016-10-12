using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using System.Net.Sockets;
using SmartHomeSimulator.Comm;
using SmartHomeSimulator.Util;

namespace SmartHomeSimulator.Test
{
    public partial class ctlTestSocketPacket : UserControl
    {
        TcpClient client = new TcpClient();

        public ctlTestSocketPacket()
        {
            InitializeComponent();
            timer.Enabled = true;
        }

        private void buttonConnect_Click(object sender, EventArgs e)
        {
            try
            {
                client.Connect("127.0.0.1", Constants.ListeningPort);                
            }
            catch
            {
                client.Close();
                client = new TcpClient();
            }
        }

        private void buttonDisconnect_Click(object sender, EventArgs e)
        {
            try
            {
                client.Close();
            }
            finally
            {
                client = new TcpClient();
            }
        }

        private void buttonTest_Click(object sender, EventArgs e)
        {
            byte[] buffer = Utility.GetBytes(textBoxTest.Text);
            client.Client.Send(buffer);
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            if (client.Connected)
            {
                buttonConnect.Enabled = false;
                buttonDisconnect.Enabled = true;
                buttonTest.Enabled = true;
            }
            else
            {
                buttonConnect.Enabled = true;
                buttonDisconnect.Enabled = false;
                buttonTest.Enabled = false;
            }
        }       
    }
}
