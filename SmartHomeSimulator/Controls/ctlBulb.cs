using SmartHomeSimulator.Model;
using System;
using System.Windows.Forms;
using SmartHomeSimulator.Util;

namespace SmartHomeSimulator.Controls
{
    public partial class ctlBulb : UserControl, IctlDevice
    {
        private bool poweredOn = false;
        private bool onlineStatus = true;

        public event NotificationEventHandler NotificationEvent;

        public ctlBulb(int id)
        {
            InitializeComponent();
            this.labelID.Text = id.ToString();
            load();
        }

        private void load()
        {
            imageList.Images.AddStrip(AdditionalResources.bulbStrip);
            pictureBox.Image = imageList.Images[0];
        }
        
        #region Properties

        public string DeviceName
        {
            get { return "Bulb"; }            
        }

        public BaseResource Resource
        {
            get
            {
                return null;
            }
        }

        public bool PoweredOn
        {
            get
            {
                return poweredOn;
            }
            set
            {
                if (poweredOn == value)
                    return;

                int imageIndex = (value) ? 1 : 0;
                pictureBox.Image = imageList.Images[imageIndex];
                poweredOn = value;

                if (checkBoxPoweredOn.Checked != value)
                    setCheckBoxState(checkBoxPoweredOn, value);

                raiseNoticationEvent("{0} turned {1}!", DeviceName, (value) ? "On" : "Off");
            }
        }

        public bool OnlineStatus
        {
            get
            {
                return onlineStatus;
            }
            set
            {
                if (onlineStatus == value)
                    return;

                onlineStatus = value;

                if (checkBoxOnlineStatus.Checked != value)
                    setCheckBoxState(checkBoxOnlineStatus, value);

                raiseNoticationEvent("{0} switched {1}!", DeviceName, (value) ? "Online" : "Offline");
            }
        }
        
        #endregion Properties

        #region Private Methods

        private void checkBoxPoweredOn_CheckedChanged(object sender, EventArgs e)
        {
            PoweredOn = checkBoxPoweredOn.Checked;
        }

        private void checkBoxOnlineStatus_CheckedChanged(object sender, EventArgs e)
        {
            OnlineStatus = checkBoxOnlineStatus.Checked;
        }
        
        private void setCheckBoxState(CheckBox chkBox, bool value)
        {
            if (chkBox.InvokeRequired)
            {
                CheckBoxDelegate invokeHandle = new CheckBoxDelegate(setCheckBoxState);
                this.Invoke(invokeHandle, chkBox, value);
            }
            else
            {
                chkBox.Checked = value;
            }
        }
        
        private void raiseNoticationEvent(string notificationMessage, params string[] args)
        {
            if (NotificationEvent != null)
                NotificationEvent(string.Format(notificationMessage,args));
        }

        #endregion Private Methods
    }
}
