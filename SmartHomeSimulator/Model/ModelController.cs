using System.IO;
using SmartHomeSimulator.Log;
using SmartHomeSimulator.Parsing;
using System.Collections.Generic;

namespace SmartHomeSimulator.Model
{
    public class ModelController
    {
        #region Singleton Pattern
        
        private static object lockingObject = new object();
        private static ModelController instance = null;
        public static ModelController Instance
        {
            get{
                lock(lockingObject)
                {
                    if(instance == null)
                        instance = new ModelController();
                }
                return instance;
            }        
        }

        #endregion Singleton Pattern

        private ModelController()
        {
            Parser parser = new Parser();

            string fileName = "layout.xml";

            if(File.Exists(fileName))
                Model = parser.Parse("layout.xml");
            else
                Model = parser.Parse();
        }

        public Building Model { get; set; }

        public Device GetDevice(int floorNumber, int roomNumber, int deviceId)
        {
            if (floorNumber >= Model.Floors.Count)
                throw new LoggedException("Invalid floor number.");

            if (roomNumber >= Model.Floors[floorNumber].Rooms.Count)
                throw new LoggedException("Invalid room number.");

            IList<Device> devices = Model.Floors[floorNumber].Rooms[roomNumber].Devices;

            foreach (Device device in devices)
            {
                if (device.ID == deviceId)
                    return device;
            }

            throw new LoggedException("Device with the specified id was not found in the specified location.");
        }

        public Device FindDevice(int deviceId)
        {
            foreach (Floor floor in Model.Floors)
                foreach (Room room in floor.Rooms)
                    foreach (Device device in room.Devices)
                    {
                        if (device.ID == deviceId)
                            return device;
                    }

            throw new LoggedException("Device with the specified id was not found.");
        }

        public int GetFloorCount()
        {
            return Model.Floors.Count;
        }

        public int GetRoomCount(int floorNumber)
        {
            if (floorNumber >= Model.Floors.Count)
                throw new LoggedException("Invalid floor number.");

            return Model.Floors[floorNumber].Rooms.Count;
        }

        public int GetDeviceCount(int floorNumber, int roomNumber)
        {
            if (floorNumber >= Model.Floors.Count)
                throw new LoggedException("Invalid floor number.");

            if (roomNumber >= Model.Floors[floorNumber].Rooms.Count)
                throw new LoggedException("Invalid room number.");

            return Model.Floors[floorNumber].Rooms[roomNumber].Devices.Count;
        }

        public List<int> GetDevices(int floorNumber, int roomNumber)
        {
            if (floorNumber >= Model.Floors.Count)
                throw new LoggedException("Invalid floor number.");

            if (roomNumber >= Model.Floors[floorNumber].Rooms.Count)
                throw new LoggedException("Invalid room number.");

            List<int> deviceIds = new List<int>();
            foreach (Device device in Model.Floors[floorNumber].Rooms[roomNumber].Devices)
            {
                deviceIds.Add(device.ID);
            }

            return deviceIds;
        }

        public List<int> GetPairedDevices(int deviceId)
        {
            Device targetDevice = FindDevice(deviceId);

            List<int> deviceIds = new List<int>();
            foreach (Device device in targetDevice.PairedDevices)
            {
                deviceIds.Add(device.ID);
            }

            return deviceIds;
        }

        internal int GetPairedDevicesCount(int deviceId)
        {
            Device targetDevice = FindDevice(deviceId);
            if (targetDevice.PairedDevices == null)
                return 0;

            return targetDevice.PairedDevices.Count;
        }

        internal Room GetRoom(int floorNumber, int roomNumber)
        {
            if (floorNumber >= Model.Floors.Count)
                throw new LoggedException("Invalid floor number.");

            if (roomNumber >= Model.Floors[floorNumber].Rooms.Count)
                throw new LoggedException("Invalid room number.");

            return Model.Floors[floorNumber].Rooms[roomNumber];
        }

        internal Floor GetFloor(int floorNumber)
        {
            if (floorNumber >= Model.Floors.Count)
                throw new LoggedException("Invalid floor number.");

            return Model.Floors[floorNumber];
        }
    }
}
