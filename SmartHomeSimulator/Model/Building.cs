using System.Collections.Generic;
using SmartHomeSimulator.Util;

namespace SmartHomeSimulator.Model
{
    public class Building : MetaModel
    {
        public IList<Floor> Floors { get; set; }

        public string StreetAddress { get; set; }

        public Building()
        {
            Name = "Smart Home v1.0";
            Floors = new SerializeableList<Floor>();
        }
    }
}
