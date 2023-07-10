using System;
using System.Runtime.InteropServices;
using System.Xml.Serialization;
	[XmlRoot(Namespace = "https://erju.org/", ElementName = "eTCSPacket_44")]
	public class ETCSPacket_44
	{		
		[XmlAttribute]
		public uint nid_xuser;		
		[XmlAttribute]
		public uint nid_ntc;		
		[XmlAttribute]
		private string? otherData;
		[XmlAttribute(AttributeName = "otherData")]
		public string OtherData
        {
            set
            {
                this.otherData = value;
            }
            get
            {
                return this.otherData != null ? this.otherData : "";   
            }
        
        }
}