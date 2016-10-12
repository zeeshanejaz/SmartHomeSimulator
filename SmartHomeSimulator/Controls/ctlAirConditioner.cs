using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using SmartHomeSimulator.Model;
using SmartHomeSimulator.Model.Interfaces;
using SmartHomeSimulator.Util;

namespace SmartHomeSimulator.Controls
{
    public partial class ctlAirConditioner : UserControl, IctlDevice
    {
        private float desiredTemp = 22;
        private float currentTemp = 30;
        private bool poweredOn = false;
        private bool onlineStatus = false;
        private string textStatus = string.Empty;
        private BaseResource resource;

        private enum AirConditionerFunction { Cooling, Heating, Standby }
        private AirConditionerFunction function = AirConditionerFunction.Cooling;
                
        public event NotificationEventHandler NotificationEvent;
        
        public ctlAirConditioner(int id)
        {
            InitializeComponent();
            this.labelID.Text = id.ToString();
            load();
        }

        private void load()
        {
            new AirConditionerResource(this);

            imageList.Images.AddStrip(AdditionalResources.upDownStrip);
            buttonDown.Image = imageList.Images[0];
            buttonUp.Image = imageList.Images[1];
            updateTextStatus();
        }

        #region Properties
        
        public string TextStatus
        {
            get
            {
                return textStatus;
            }
        }

        public string DeviceName
        {
            get
            {
                return "Air Conditioner";
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
                timer.Enabled = value;

                if (checkBoxPoweredOn.Checked != value)
                    setCheckBoxState(checkBoxPoweredOn, value);

                updateTextStatus();
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

        private void updateTextStatus()
        {
            if (desiredTemp < currentTemp)
                function = AirConditionerFunction.Cooling;
            else if (desiredTemp > currentTemp)
                function = AirConditionerFunction.Heating;
            else
                function = AirConditionerFunction.Standby;


            if (!poweredOn)
            {
                textStatus = "Off";

                labelCurrent.Text = string.Empty;
                labelDesired.Text = textStatus;
                labelFunction.Text = string.Empty;
            }
            else
            {
                textStatus = string.Format("Desired Temprature: {0} °C \nCurrent Temprature: {1} °C\n{2}", desiredTemp, currentTemp, function);

                labelCurrent.Text = string.Format("{0} °C", currentTemp);
                labelDesired.Text = desiredTemp.ToString();
                labelFunction.Text = function.ToString();
            }
        }

        #endregion Private Methods

        #region Temprature Related

        private bool ExecuteCommand(int commandId)
        {
            if (!this.PoweredOn)
                return false;

            bool handled = true;

            switch (commandId)
            {
                case 0:
                    up();
                    break;

                case 1:
                    down();
                    break;

                default:
                    handled = false;
                    break;
            }

            return handled;
        }
                
        private void up()
        {
            if (!this.PoweredOn)
                return;

            if (desiredTemp < 30)
            {
                desiredTemp = (float)Math.Round(desiredTemp + 0.5f, 1);
                updateTextStatus();
            }
        }

        private void down()
        {
            if (!this.PoweredOn)
                return;

            if (desiredTemp > 15)
            {
                desiredTemp = (float)Math.Round(desiredTemp - 0.5f, 1);
                updateTextStatus();
            }
        }

        private void buttonUp_Click(object sender, EventArgs e)
        {
            up();
        }

        private void buttonDown_Click(object sender, EventArgs e)
        {
            down();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            if (desiredTemp > currentTemp)
            {
                currentTemp = (float) Math.Round(currentTemp + 0.1f, 1);
            }
            else if (desiredTemp < currentTemp)
            {
                currentTemp = (float) Math.Round(currentTemp - 0.1f, 1);
            }

            updateTextStatus();
        }

        #endregion Temprature Related
        
        #region Resource Section

        internal class AirConditionerResource : BaseResource, ITextEnabled, ICommandEnabled
        {
            public AirConditionerResource(ctlAirConditioner ctlAirConditioner)
                : base(ctlAirConditioner)
            {
                ctlAirConditioner.Resource = this;
            }

            public string TextStatus
            {
                get
                {
                    return (Parent as ctlAirConditioner).TextStatus;
                }
            }

            public int MaxCommandId
            {
                get { return 1; }
            }

            public bool ExecuteCommand(int commandId)
            {
                return (Parent as ctlAirConditioner).ExecuteCommand(commandId);
            }
        }

        #endregion Resource Section
    }
}
