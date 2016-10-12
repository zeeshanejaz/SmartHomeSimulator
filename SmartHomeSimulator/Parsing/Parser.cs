using SmartHomeSimulator.Log;
using SmartHomeSimulator.Model;
using System;
using System.IO;
using System.Collections.Generic;
using System.Xml;

namespace SmartHomeSimulator.Parsing
{
    class Parser
    {
        private XmlDocument document = null;
        private Dictionary<int, Device> deviceTable = new Dictionary<int, Device>();
        private Dictionary<Device, List<int>> associationTable = new Dictionary<Device, List<int>>();

        internal Building Parse()
        {
            StringReader layout = new StringReader(AdditionalResources.layout);
            XmlReader reader = XmlReader.Create(layout);
            return parse(reader);
        }

        public Building Parse(string fileName)
        {
            XmlReader reader = XmlReader.Create(fileName);
            return parse(reader);
        }

        private Building parse(XmlReader reader)
        {
            document = new XmlDocument();
            document.Load(reader);

            XmlElement root = document.DocumentElement;
         
            if (root.ChildNodes.Count <= 0)
                throw new LoggedException("Unexpected format of the file. Expected a Building element.");
                        
            Building buildingModel = parseBuilding(root);

            resolveAssociations();
            
            return buildingModel;
        }

        private void resolveAssociations()
        {
            foreach (Device device in associationTable.Keys)
            {
                List<int> associationIds = associationTable[device];

                foreach (int associationId in associationIds)
                {
                    if (!deviceTable.ContainsKey(associationId))
                        throw new LoggedException("Unable to resolve device association.");

                    Device associatedDevice = deviceTable[associationId];
                    device.PairedDevices.Add(associatedDevice);
                }
            }

            //cleanup
            deviceTable.Clear();
            associationTable.Clear();
        }

        private Building parseBuilding(XmlNode buildingNode)
        {
            if (buildingNode.ChildNodes.Count <= 0)
                throw new LoggedException("Unexpected format of the file. Expected atleast one Floor element.");

            Building buildingModel = new Building();
            buildingModel.StreetAddress = buildingNode.Attributes["StreetAddress"].Value;

            foreach (XmlNode floorNode in buildingNode.ChildNodes)
            {
                if (!floorNode.Name.Equals("Floor", StringComparison.InvariantCultureIgnoreCase))
                    throw new LoggedException("Unexpected format of the file. Expected a Floor element.");

                Floor floorModel = parseFloor(floorNode);
                buildingModel.Floors.Add(floorModel);
            }

            return buildingModel;
        }

        private Floor parseFloor(XmlNode floorNode)
        {
            if (floorNode.ChildNodes.Count <= 0)
                throw new LoggedException("Unexpected format of the file. Expected atleast one Room element.");

            Floor floorModel = new Floor();
            floorModel.Name = floorNode.Attributes["Name"].Value;

            foreach (XmlNode roomNode in floorNode.ChildNodes)
            {
                if (!roomNode.Name.Equals("Room", StringComparison.InvariantCultureIgnoreCase))
                    throw new LoggedException("Unexpected format of the file. Expected a Room element.");

                Room roomModel = parseRoom(roomNode);
                floorModel.Rooms.Add(roomModel);
            }

            return floorModel;
        }

        private Room parseRoom(XmlNode roomNode)
        {
            if (roomNode.ChildNodes.Count <= 0)
                throw new LoggedException("Unexpected format of the file. Expected atleast one Device element.");

            Room roomModel = new Room();
            roomModel.Name = roomNode.Attributes["Name"].Value;

            foreach (XmlNode deviceNode in roomNode.ChildNodes)
            {
                if (!deviceNode.Name.Equals("Device", StringComparison.InvariantCultureIgnoreCase))
                    throw new LoggedException("Unexpected format of the file. Expected a Device element.");

                Device deviceModel = parseDevice(deviceNode);
                roomModel.Devices.Add(deviceModel);
            }                        

            return roomModel;
        }

        private Device parseDevice(XmlNode deviceNode)
        {
            string strId = deviceNode.Attributes["Id"].Value;
            string strType = deviceNode.Attributes["Type"].Value;

            int id = 0;
            bool success = int.TryParse(strId, out id);
            if (!success)
                throw new LoggedException("Unexpected format of Device Id. Expecting an integer.");

            Device deviceModel = new Device(id, strType);

            if (deviceNode.HasChildNodes) 
            {
                associationTable.Add(deviceModel, new List<int>());

                foreach (XmlNode associatedDeviceNode in deviceNode.ChildNodes)
                {
                    if (!associatedDeviceNode.Name.Equals("Association", StringComparison.InvariantCultureIgnoreCase))
                        throw new LoggedException("Unexpected format of the file. Expected a Association element.");

                    string strAssociatedID = associatedDeviceNode.Attributes["Id"].Value;
                    int associatedID = 0;
                    success = int.TryParse(strAssociatedID, out associatedID);
                    if (!success)
                        throw new LoggedException("Unexpected format of Assocaited Device Id. Expecting an integer.");

                    //cannot associate with itself
                    if (associatedID.Equals(id))
                        continue;

                    associationTable[deviceModel].Add(associatedID);
                }
            }

            if (deviceTable.ContainsKey(id))
                throw new LoggedException("Device IDs mut be unique in the scope of this layout.");

            deviceTable.Add(id, deviceModel);

            return deviceModel;
        }
    }
}
