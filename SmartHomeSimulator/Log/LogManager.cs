namespace SmartHomeSimulator.Log
{
    internal class LogManager
    {
        public static void LogMessage(string message)
        {
            ViewForm.Instance.AddLog(message);
        }
    }
}
