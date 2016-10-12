using SmartHomeSimulator.Model;
using SmartHomeSimulator.Model.Interfaces;
using System;
using System.Windows.Forms;
using SmartHomeSimulator.Util;

namespace SmartHomeSimulator.Controls
{
    public partial class ctlCDPlayer : UserControl, IctlDevice
    {
        private bool poweredOn = false;
        private bool onlineStatus = true;
        private string textStatus = "Powered Off";
        private BaseResource resource;

        public event NotificationEventHandler NotificationEvent;

        public ctlCDPlayer(int id)
        {
            InitializeComponent();
            this.labelID.Text = id.ToString();

            load();
        }
        
        private void load()
        {
            new CDPlayerResource(this);

            imageList.Images.AddStrip(AdditionalResources.mediaStrip);
            pictureBoxPause.Image = imageList.Images[0];
            pictureBoxStop.Image = imageList.Images[1];
            pictureBoxPlay.Image = imageList.Images[2];
            pictureBoxNext.Image = imageList.Images[3];
            pictureBoxPrev.Image = imageList.Images[4];
        }

        #region Properties

        public string DeviceName
        {
            get
            {
                return "CD Player";
            }
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
                
                TextStatus = (value) ? "Powered On" : " Powered Off";
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

        private string TextStatus
        {
            get
            {
                return textStatus;
            }
            set
            {
                textStatus = value;
                labelStatus.Text = textStatus;
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

        #region Media Related

        private bool ExecuteCommand(int commandId)
        {
            if (!this.PoweredOn)
                return false;

            bool handled = true;

            switch (commandId)
            {
                case 0:
                    pause();
                    break;

                case 1:
                    stop();
                    break;

                case 2:
                    play();
                    break;

                case 3:
                    next();
                    break;

                case 4:
                    previous();
                    break;

                default:
                    handled = false;
                    break;
            }
            
            return handled;
        }

        private void play()
        {
            if (poweredOn)
                TextStatus = tracks[current];            
        }

        private void pause()
        {
            if (poweredOn)
                TextStatus = "Paused";
        }

        private void stop()
        {
            if (poweredOn)
            {
                TextStatus = "Stopped";
                current = 0;
            }
        }

        private void next()
        {
            if (poweredOn && (current < (tracks.Length - 1)))
            {
                current++;
                play();
            }
        }

        private void previous()
        {
            if (poweredOn && (current > 0))
            {
                current--;
                play();
            }
        }

        private string[] tracks = new string[] { "Track 01", "Track 02", "Track 03", 
            "Track 04", "Track 05", "Track 06", "Track 07", "Track 08", "Track 09" };

        private int current = 0;

        private void pictureBoxPause_Click(object sender, EventArgs e)
        {
            pause();
        }

        private void pictureBoxStop_Click(object sender, EventArgs e)
        {
            stop();
        }

        private void pictureBoxPlay_Click(object sender, EventArgs e)
        {
            play();
        }

        private void pictureBoxNext_Click(object sender, EventArgs e)
        {
            next();
        }

        private void pictureBoxPrev_Click(object sender, EventArgs e)
        {
            previous();
        }

        #endregion Media Related

        #region Resource Section

        internal class CDPlayerResource : BaseResource, ITextEnabled, ICommandEnabled
        {
            public CDPlayerResource(ctlCDPlayer ctlCDPlayer)
                : base(ctlCDPlayer)
            {
                ctlCDPlayer.Resource = this;
            }
                
            public string TextStatus
            {
                get
                {
                    return (Parent as ctlCDPlayer).TextStatus;
                }
            }

            public bool ExecuteCommand(int commandId)
            {
                return (Parent as ctlCDPlayer).ExecuteCommand(commandId);
            }

            public int MaxCommandId
            {
                get { return 4; }
            }
        }

        #endregion Resource Section
    }
}
