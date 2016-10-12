
namespace SmartHomeSimulator.Model.Interfaces
{
    interface ICommandEnabled
    {
        int MaxCommandId { get; }
        bool ExecuteCommand(int commandId);
    }
}
