using System.Collections.Generic;
using SmartHomeSimulator.Util;

namespace SmartHomeSimulator.Model
{
    public class Room : MetaModel
    {
        public IList<Device> Devices { get; set; }
        
        public Room()
        {
            Devices = new SerializeableList<Device>();
        }
    }
}
