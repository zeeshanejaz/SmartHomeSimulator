using System;
using System.Collections.Generic;
using System.Text;

namespace SmartHomeSimulator.Util
{
    class SerializeableList<T> : List<T>
    {
        public override string ToString()
        {
            StringBuilder stringBuilder = new StringBuilder("|");

            foreach (T item in this)
            {
                stringBuilder.AppendFormat("{0}|", item.ToString());
            }

            return stringBuilder.ToString();
        }
    }
}
