using System.Collections.Generic;
using SmartHomeSimulator.Util;

namespace SmartHomeSimulator.Model
{
    public class Floor : MetaModel
    {
        public IList<Room> Rooms { get; set; }

        public Floor()
        {
            Rooms = new SerializeableList<Room>();
        }
    }
}
