using SmartHomeSimulator.Controls;
using System;
using System.Windows.Forms;
using SmartHomeSimulator.Log;
using SmartHomeSimulator.Comm;
using SmartHomeSimulator.Util;
using SmartHomeSimulator.Properties;

namespace SmartHomeSimulator
{
    public partial class ViewForm : Form
    {
        #region Singleton Pattern

        private static object lockingObject = new object();
        private static ViewForm instance = null;
        public static ViewForm Instance
        {
            get
            {
                lock (lockingObject)
                {
                    if (instance == null)
                        instance = new ViewForm();
                }
                return instance;
            }
        }

        #endregion Singleton Pattern

        private ViewForm()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
        }

        public Control AddFloor(string floorName)
        {
            this.SuspendLayout();

            TabPage tabFloor = new TabPage();
            tabFloor.Text = floorName;
            tabFloors.TabPages.Add(tabFloor);

            this.ResumeLayout();

            return tabFloor;
        }

        public Control AddRoom(Control floor, string roomName, bool isLast)
        {
            this.SuspendLayout();

            TabPage tabFloor = floor as TabPage;
            
            Panel roomPanel = new Panel();
            roomPanel.BorderStyle = BorderStyle.FixedSingle;
            roomPanel.AutoScroll = true;
            roomPanel.Width = 300;            

            Label roomLabel = new Label();
            roomLabel.Text = roomName;
            roomPanel.Controls.Add(roomLabel);
            roomLabel.Dock = DockStyle.Top;

            tabFloor.Controls.Add(roomPanel);            
            roomPanel.Dock = (isLast) ? DockStyle.Fill : DockStyle.Left;
            roomPanel.BringToFront();

            if (!isLast)
            {
                Splitter roomSplitter = new Splitter();
                tabFloor.Controls.Add(roomSplitter);
                roomSplitter.BringToFront();
            }

            this.ResumeLayout();

            return roomPanel;
        }

        public Control AddDevice(Control room, string deviceType, int id)
        {
            this.SuspendLayout();
                        
            Control deviceCtl = createDevice(deviceType, id) as Control;

            room.Controls.Add(deviceCtl);
            deviceCtl.Dock = DockStyle.Top;
            deviceCtl.BringToFront();

            this.ResumeLayout();

            return deviceCtl;
        }

        private IctlDevice createDevice(string deviceType, int id)
        {
            IctlDevice deviceCtl = null;
            switch (deviceType)
            {
                case "Bulb":
                    deviceCtl = new ctlBulb(id);
                    break;

                case "CD Player":
                    deviceCtl = new ctlCDPlayer(id);
                    break;

                case "Window":
                    deviceCtl = new ctlWindow(id);
                    break;

                case "Air Conditioner":
                    deviceCtl = new ctlAirConditioner(id);
                    break;

                default:
                    throw new LoggedException("Unknow device type specified : {0}.", deviceType);
            }

            deviceCtl.NotificationEvent += deviceCtl_NotificationEvent;

            return deviceCtl;
        }

        void deviceCtl_NotificationEvent(string notification)
        {
            AddLog(string.Format("Event = {0} ", notification));
        }

        internal void AddLog(string message)
        {
            if (listBoxLogs.InvokeRequired)
            {
                StringDelegate invokeHandle = new StringDelegate(AddLog);
                this.Invoke(invokeHandle, message);
            }
            else
            {
                int index = listBoxLogs.Items.Add(string.Format("{0} :: {1}", DateTime.Now.ToShortTimeString(), message));
                listBoxLogs.SelectedIndex = index;
                listBoxLogs.SelectedIndex = -1;
            }
        }

        bool lastConnectionStatus = false;
        private void timer_Tick(object sender, EventArgs e)
        {
            bool connected = ProtocolManager.Instance.ClientsConnected;

            if (lastConnectionStatus == connected)
                return;

            if (connected)
            {
                statusConnection.Text = "Connected";
                statusConnection.Image = Resources.green;
            }
            else
            {
                statusConnection.Text = "Disconnected";
                statusConnection.Image = Resources.red;
            }

            lastConnectionStatus = connected;
        }
    }
}
