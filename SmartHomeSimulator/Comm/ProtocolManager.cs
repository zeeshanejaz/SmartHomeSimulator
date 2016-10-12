using System;
using SmartHomeSimulator.Log;
using SmartHomeSimulator.Model;
using System.Collections.Generic;

namespace SmartHomeSimulator.Comm
{
    public class ProtocolManager : IDisposable
    {
        #region Singleton Pattern

        private static object lockingObject = new object();
        private static ProtocolManager instance = null;
        public static ProtocolManager Instance
        {
            get
            {
                lock (lockingObject)
                {
                    if (instance == null)
                        instance = new ProtocolManager();
                }
                return instance;
            }
        }

        #endregion Singleton Pattern

        private CommServer commServer = null;

        public ProtocolManager()
        {
            commServer = new CommServer();
            commServer.Start();
        }

        public ProtocolPacket ProcessRequestPacket(ProtocolPacket packet)
        {
            try
            {
                if (packet.PacketType != PacketType.Request)
                    throw new LoggedException("Malformatted packet. Packet type should be request.");

                switch (packet.RequestType)
                {
                    case RequestType.Get:
                    case RequestType.Set:
                        return processAttributePacket(packet);

                    case RequestType.Enumeration:
                        return processEnumerationPacket(packet);

                    case RequestType.Execute:
                        return processExecutePacket(packet);

                    default:
                        throw new LoggedException("Malformatted packet. Request type not supported.");
                }
            }
            catch
            {
                return null;
            }
        }

        private ProtocolPacket processExecutePacket(ProtocolPacket packet)
        {
            if (packet.TargetType != TargetType.Device)
                throw new LoggedException("Invalid request. Only devices support status requests.");

            int[] parameters = parseParamIds(packet);
            if (parameters.Length < 1)
                throw new LoggedException("Incorrect packet format. Expected one integer parameter.");

            int deviceId = parameters[0];
            Device device = ModelController.Instance.FindDevice(deviceId);
            packet.Parameters.RemoveAt(0);

            string payLoad = device.ExecuteMethod(packet.TargetArticle, packet.Parameters);
            ProtocolPacket response = packet.PrepareResponse();

            response.Parameters.Add(payLoad);
            return response;
        }

        private ProtocolPacket processEnumerationPacket(ProtocolPacket packet)
        {
            int count = -1;
            int[] parameters = parseParamIds(packet);

            switch (packet.TargetType)
            {
                case TargetType.Building:
                    count = 1;
                    break;

                case TargetType.Floor:
                    count = ModelController.Instance.GetFloorCount();
                    break;

                case TargetType.Room:
                    if (parameters.Length < 1)
                        throw new LoggedException("Incorrect packet format. Expected one integer parameter.");

                    count = ModelController.Instance.GetRoomCount(parameters[0]);
                    break;

                case TargetType.Device:
                    if (parameters.Length < 2)
                        throw new LoggedException("Incorrect packet format. Expected two integer parameters.");

                    count = ModelController.Instance.GetDeviceCount(parameters[0], parameters[1]);
                    break;

                case TargetType.Paired:
                    if (parameters.Length < 1)
                        throw new LoggedException("Incorrect packet format. Expected one integer parameter.");

                    count = ModelController.Instance.GetPairedDevicesCount(parameters[0]);
                    break;

                default:
                    throw new LoggedException("Malformatted packet. Target type not supported.");
            }

            string payLoad = count.ToString();
            ProtocolPacket response = packet.PrepareResponse();

            response.Parameters.Add(payLoad);
            return response;
        }

        private ProtocolPacket processAttributePacket(ProtocolPacket packet)
        {
            int[] idParameters = parseParamIds(packet);

            object targetObject = null;

            switch (packet.TargetType)
            {
                case TargetType.Building:
                    targetObject = ModelController.Instance.Model;
                    break;

                case TargetType.Floor:
                    if (idParameters.Length < 1)
                        throw new LoggedException("Incorrect packet format. Expected an integer parameter.");

                    packet.Parameters.RemoveAt(0);
                    targetObject = ModelController.Instance.GetFloor(idParameters[0]);
                    break;

                case TargetType.Room:
                    if (idParameters.Length < 2)
                        throw new LoggedException("Incorrect packet format. Expected two integer parameters.");

                    packet.Parameters.RemoveAt(0);
                    packet.Parameters.RemoveAt(0);
                    targetObject = ModelController.Instance.GetRoom(idParameters[0], idParameters[1]);
                    break;

                case TargetType.Device:
                    if (idParameters.Length < 1)
                        throw new LoggedException("Incorrect packet format. Expected an integer parameter.");

                    packet.Parameters.RemoveAt(0);
                    targetObject = ModelController.Instance.FindDevice(idParameters[0]);
                    break;

                default:
                    throw new LoggedException("Malformatted packet. Target type not supported.");
            }

            if(!(targetObject is MetaModel))
                throw new LoggedException("Invalid request. Target type not supported.");

            ProtocolPacket response = packet.PrepareResponse();
            string payLoad = string.Empty;

            if (packet.RequestType == RequestType.Get)
            {
                payLoad = (targetObject as MetaModel).ReadPropertyValue(packet.TargetArticle);                
            }
            else
            {
                if(packet.Parameters.Count <= 0)
                    throw new LoggedException("Incorrect packet format. Expected a parameter.");

                (targetObject as MetaModel).WritePropertyValue(packet.TargetArticle, packet.Parameters[0]);

                payLoad = true.ToString();
            }

            response.Parameters.Add(payLoad);
            return response;
        }

        private static int[] parseParamIds(ProtocolPacket packet)
        {
            List<int> parameters = new List<int>();

            int parameterCount = 0;
            foreach (string parameter in packet.Parameters)
            {
                if (string.IsNullOrEmpty(parameter))
                    throw new LoggedException("Malformatted packet. Null parameter detected.");

                int parameterValue = -1;
                bool parsed = int.TryParse(parameter, out parameterValue);

                //only leading parameters are integers
                if (!parsed)
                    break;

                parameters.Add(parameterValue);

                parameterCount++;
            }

            return parameters.ToArray();
        }

        public void Dispose()
        {
            if (commServer != null)
                commServer.Stop();

            commServer = null;
        }

        public bool ClientsConnected
        {
            get
            {
                return commServer.HasClients;
            }
        }
    }
}
