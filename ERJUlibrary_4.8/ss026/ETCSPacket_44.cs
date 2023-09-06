using System.Xml.Serialization;
using System.Collections.Generic;
namespace ss026
{
	[XmlRoot(Namespace = "https://erju.org/ss026", ElementName = "eTCSPacket_44")]
	public class ETCSPacket_44
	{
		[XmlAttribute]
		public uint nid_xuser;
		[XmlAttribute]
		public uint nid_ntc;
		private string otherData;
		[XmlAttribute(AttributeName = "otherData")]
		public string OtherData
		{
			set
			{
				this.otherData = value;
			}
			get
			{
				return this.otherData != null?  this.otherData : "";
			}
}

	}
}
