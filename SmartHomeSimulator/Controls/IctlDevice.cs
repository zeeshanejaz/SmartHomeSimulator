using SmartHomeSimulator.Model;

namespace SmartHomeSimulator.Controls
{
    public delegate void NotificationEventHandler(string notification);

    public interface IctlDevice
    {
        string DeviceName { get; }

        bool PoweredOn { get; set; }

        bool OnlineStatus { get; }

        BaseResource Resource { get; }

        event NotificationEventHandler NotificationEvent;
    }
}
