using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using SmartHomeSimulator.Comm;

namespace SmartHomeSimulator
{
    public partial class ctlTestDirectPacket : UserControl
    {
        public ctlTestDirectPacket()
        {
            InitializeComponent();
        }

        private void buttonTest_Click(object sender, EventArgs e)
        {
            try
            {
                ProtocolPacket packet = ProtocolPacket.Parse(textBoxTest.Text);
                ProtocolPacket result = ProtocolManager.Instance.ProcessRequestPacket(packet);
                if (result == null)
                    labelResult.Text = "Result: Failure, see logs";
                else if (result.Parameters.Count > 0)
                    labelResult.Text = "Result: " + result.Parameters[0];
                else
                    labelResult.Text = "Result: Success";
            }
            catch
            {
                labelResult.Text = "Result: Failure, see logs";
            }
        }
    }
}
