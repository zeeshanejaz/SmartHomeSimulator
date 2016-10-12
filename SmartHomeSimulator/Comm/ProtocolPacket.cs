using SmartHomeSimulator.Log;
using System;
using System.Text;
using System.Collections.Generic;

namespace SmartHomeSimulator.Comm
{
    public class ProtocolPacket
    {
        // |PacketType|TargetType|RequestType|TargetId|Command|Parameter|

        public PacketType PacketType { get; set; }

        public TargetType TargetType { get; set; }

        public RequestType RequestType { get; set; }
        
        public string TargetArticle { get; set; }

        public List<string> Parameters { get; set; }

        public ProtocolPacket PrepareResponse()
        {
            ProtocolPacket packet = new ProtocolPacket();
            packet.PacketType = PacketType.Response;
            packet.TargetType = this.TargetType;
            packet.RequestType = this.RequestType;
            packet.TargetArticle = this.TargetArticle;
            packet.Parameters = new List<string>();
            return packet;
        }

        internal static ProtocolPacket Parse(string strPacket)
        {
            string[] tokens = strPacket.Split(new char[] { '|' }, StringSplitOptions.RemoveEmptyEntries);

            if (tokens.Length < 3)
                throw new LoggedException("Invalid packet format. Expected mandatory segment tokens.");

            ProtocolPacket packet = new ProtocolPacket();
            packet.PacketType = (PacketType)Enum.Parse(typeof(PacketType), tokens[0], true);
            packet.TargetType = (TargetType)Enum.Parse(typeof(TargetType), tokens[1], true);
            packet.RequestType = (RequestType)Enum.Parse(typeof(RequestType), tokens[2], true);

            packet.Parameters = new List<string>();

            if (tokens.Length >= 4)
            {
                packet.TargetArticle = tokens[3];

                for (int i = 4; i < tokens.Length; i++)
                    packet.Parameters.Add(tokens[i]);
            }

            return packet;
        }

        public override string ToString()
        {
            StringBuilder builder = new StringBuilder();
            //mandatory packets
            builder.AppendFormat("|{0}|{1}|{2}|", this.PacketType, this.TargetType, this.RequestType);

            if (!string.IsNullOrEmpty(this.TargetArticle))
                builder.AppendFormat("{0}|", this.TargetArticle);
            else
                builder.AppendFormat(" |");//must fill the place holder so that paramters are not miss-aligned

            if (this.Parameters != null)
            {
                foreach (string param in this.Parameters)
                {
                    builder.AppendFormat("{0}|", param);
                }
            }

            return builder.ToString();
        }
    }

    public enum PacketType
    {
        Request     = 0,
        Response    = 1,
        Push        = 2,
    }

    public enum TargetType
    {
        Building    = 0,
        Floor       = 1,
        Room        = 2,
        Device      = 3,
        Paired      = 4,
    }

    public enum RequestType
    {
        Enumeration = 0,
        Get         = 1,
        Set         = 2,
        Execute     = 3,
    }
}
