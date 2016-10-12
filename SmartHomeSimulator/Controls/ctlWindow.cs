using SmartHomeSimulator.Log;
using SmartHomeSimulator.Model;
using SmartHomeSimulator.Model.Interfaces;
using System;
using System.Windows.Forms;
using SmartHomeSimulator.Util;

namespace SmartHomeSimulator.Controls
{
    public partial class ctlWindow : UserControl, IctlDevice
    {
        private bool open = false;
        private bool poweredOn = false;
        private bool onlineStatus = true;
        private bool safeStatus = true;
        private BaseResource resource;

        public event NotificationEventHandler NotificationEvent;

        public ctlWindow(int id)
        {
            InitializeComponent();
            this.labelID.Text = id.ToString();
            load();
        }

        private void load()
        {
            new WindowResource(this);

            imageList.Images.AddStrip(AdditionalResources.windowStrip);
            pictureBox.Image = imageList.Images[0];
        }

        #region Properties

        public string DeviceName
        {
            get { return "Window"; }
        }

        public BaseResource Resource
        {
            get
            {
                return resource;
            }
            private set
            {
                resource = value;
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
            private set
            {
                if (onlineStatus == value)
                    return;

                onlineStatus = value;

                if (checkBoxOnlineStatus.Checked != value)
                    setCheckBoxState(checkBoxOnlineStatus, value);

                raiseNoticationEvent("{0} switched {1}!", DeviceName, (value) ? "Online" : "Offline");
            }
        }

        public bool SafetyStatus
        {
            get
            {
                return safeStatus;
            }
            private set
            {
                safeStatus = value;

                raiseNoticationEvent("{0} is {1}!", DeviceName, (value) ? "Safe" : "Unsafe");
            }
        }

        public string TextStatus
        {
            get
            {
                return open.ToString();
            }
        }

        #endregion Properties

        #region Private Methods

        private void checkBoxPoweredOn_CheckedChanged(object sender, EventArgs e)
        {
            if (!safeStatus)
            {
                MessageBox.Show("Device is currently unsafe.");
                checkBoxPoweredOn.CheckedChanged -=checkBoxPoweredOn_CheckedChanged;
                checkBoxPoweredOn.Checked = !checkBoxPoweredOn.Checked;
                checkBoxPoweredOn.CheckedChanged += checkBoxPoweredOn_CheckedChanged;

                return;
            }

            PoweredOn = checkBoxPoweredOn.Checked;
        }

        private void checkBoxOnlineStatus_CheckedChanged(object sender, EventArgs e)
        {
            OnlineStatus = checkBoxOnlineStatus.Checked;
        }

        private void checkBoxSafe_CheckedChanged(object sender, EventArgs e)
        {
            SafetyStatus = checkBoxSafe.Checked;
        }

        private void checkBoxOpen_CheckedChanged(object sender, EventArgs e)
        {
            operateWindow(checkBoxOpen.Checked);
        }

        private void raiseNoticationEvent(string notificationMessage, params string[] args)
        {
            if (NotificationEvent != null)
                NotificationEvent(string.Format(notificationMessage, args));
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

        #endregion Private Methods

        #region Window Related

        private bool ExecuteCommand(int commandId)
        {
            if (!this.PoweredOn)
                return false;

            if (!safeStatus)
                throw new LoggedException("A device was manipulated when it was unsafe.");

            bool handled = true;

            switch (commandId)
            {
                case 0:
                    operateWindow(true);
                    break;

                case 1:
                    operateWindow(false);
                    break;

                default:
                    handled = false;
                    break;
            }

            return handled;
        }

        private void operateWindow(bool req)
        {
            if (open == req)
                return;

            int imageIndex = (req) ? 1 : 0;
            pictureBox.Image = imageList.Images[imageIndex];
            open = req;

            if (checkBoxOpen.Checked != req)
                checkBoxOpen.Checked = req;
        }

        #endregion Window Related

        #region Resource Section

        internal class WindowResource : BaseResource, ISafetyRelated, ITextEnabled, ICommandEnabled
        {
            public WindowResource(ctlWindow ctlWindow)
                :base(ctlWindow)
            {
                ctlWindow.Resource = this;
            }

            public bool SafetyStatus
            {
                get
                {
                    return (Parent as ctlWindow).SafetyStatus;
                }
            }

            public int MaxCommandId
            {
                get { return 1; }
            }

            public bool ExecuteCommand(int commandId)
            {
                return (Parent as ctlWindow).ExecuteCommand(commandId);
            }

            public string TextStatus
            {
                get { return (Parent as ctlWindow).TextStatus; }
            }
        }

        #endregion Resource Section

        
    }
}
