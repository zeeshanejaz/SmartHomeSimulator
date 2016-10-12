using System;

namespace SmartHomeSimulator.Comm
{
    class Constants
    {
        public static int ListeningPort = 7878;
        public static TimeSpan LongWait = new TimeSpan(0, 0, 1);
        public static TimeSpan ShortWait = new TimeSpan(0, 0, 0, 0, 100);
    }
}
