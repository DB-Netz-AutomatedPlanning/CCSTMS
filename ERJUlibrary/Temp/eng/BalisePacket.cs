using System;
using System.Collections;
using System.Runtime.InteropServices;
using System.Xml;
using System.Xml.Linq;
using System.Xml.Schema;
using System.Xml.Serialization;
namespace eng
{
	[XmlRoot(Namespace = "https://erju.org/eng", ElementName = "balisePacket")]
	public class BalisePacket : IXmlSerializable
	{
        [XmlIgnore]
		public uint nid;

		private byte[]? packet;
        [XmlIgnore]
        public byte[] Packet
        {
            set
            {
                this.packet = value;
            }
            get
            {
                return this.packet != null ? this.packet : new byte[] {};
            }
        }

        public XmlSchema? GetSchema()
        {
            return null;
        }

        public void ReadXml(XmlReader reader)
        {
            int.TryParse(reader.GetAttribute("nid"), out int _nid);
            nid = (uint)_nid;

            var data = reader.GetAttribute("packet")?.ToString();
            Packet = data!=null?Convert.FromBase64String(data): new byte[] { };

            reader.Read();
        }

        public void WriteXml(XmlWriter writer)
        {
            writer.WriteAttributeString("nid", nid.ToString());
            writer.WriteAttributeString("packet", Convert.ToBase64String(Packet));
        }
    }
}