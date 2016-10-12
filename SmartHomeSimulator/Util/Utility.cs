using System;
using System.Collections.Generic;
using System.Text;

namespace SmartHomeSimulator.Util
{
    public static class Utility
    {
        public static byte[] GetBytes(string str)
        {
            return Encoding.ASCII.GetBytes(str);
        }

        public static string GetString(byte[] bytes)
        {
            return Encoding.ASCII.GetString(bytes);
        }
    }
}
