using SmartHomeSimulator.Controls;
using SmartHomeSimulator.Log;
using SmartHomeSimulator.Model.Interfaces;
using System.Collections.Generic;
using System.Windows.Forms;
using SmartHomeSimulator.Util;

namespace SmartHomeSimulator.Model
{
    public delegate void PropertChangedEventHandler(string propertyName);

    public class Device : MetaModel
    {
        public Device(int id, string type)
        {
            ID = id;
            Type = type;
            PairedDevices = new SerializeableList<Device>();
            this.View = null;
        }

        #region View Related

        public IctlDevice View { get; set; }

        #endregion View Related

        #region Properties

        public int ID { get; set; }

        public string Type { get; set; }
                
        public bool PoweredOn
        {
            get
            {
                return View.PoweredOn;
            }
            set
            {
                View.PoweredOn = value;
                
                foreach (Device device in PairedDevices)
                {
                    device.PoweredOn = value;
                }
            }
        }

        public bool OnlineStatus
        {
            get
            {
                return View.OnlineStatus;
            }
        }

        public IList<Device> PairedDevices { get; set; }

        #endregion Properties

        #region Methods

        public bool IsSafetyRelated()
        {
            return (View.Resource is ISafetyRelated);
        }

        public bool IsTextEnabled()
        {
            return (View.Resource is ITextEnabled);
        }

        public bool IsCommandEnabled()
        {
            return (View.Resource is ICommandEnabled);
        }

        public bool ExecuteCommand(int commandId)
        {
            if (!(View.Resource is ICommandEnabled))
                throw new LoggedException("This device does not support executing commands.");

            int maxCommand = GetMaxCommandId();
            if(commandId > maxCommand || commandId < 0)
                throw new LoggedException("This device does not support requested command.");

            bool result = (View.Resource as ICommandEnabled).ExecuteCommand(commandId);

            if(!result)
                throw new LoggedException("This device could not execute requested command.");

            return result;
        }

        public int GetMaxCommandId()
        {
            if (!(View.Resource is ICommandEnabled))
                throw new LoggedException("This device does not support commands.");

            return (View.Resource as ICommandEnabled).MaxCommandId;
        }

        public string GetTextStatus()
        {
            if (!(View.Resource is ITextEnabled))
                throw new LoggedException("This device does not support text status.");

            return (View.Resource as ITextEnabled).TextStatus;
        }

        public bool GetSafetyStatus()
        {
            if (!(View.Resource is ISafetyRelated))
                throw new LoggedException("This device does not support safety status.");

            return (View.Resource as ISafetyRelated).SafetyStatus;
        }

        #endregion Methods

        #region overrides 

        public override string ToString()
        {
            return ID.ToString();
        }

        public override string Name
        {
            get
            {
                if (View != null)
                    return View.DeviceName;

                return base.Name;
            }
            set
            {
                base.Name = value;
            }
        }

        #endregion overrides
    }
}
