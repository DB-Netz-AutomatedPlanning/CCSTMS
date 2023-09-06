using System.Xml.Serialization;
using System.Collections.Generic;
namespace infra
{
	[XmlRoot(Namespace = "https://erju.org/infra", ElementName = "nationalBorder")]
	public class NationalBorder
	{
		private string id;
		[XmlAttribute(AttributeName = "id")]
		public string Id
		{
			set
			{
				this.id = value;
			}
			get
			{
				return this.id != null?  this.id : "";
			}
}
		private string name;
		[XmlAttribute(AttributeName = "name")]
		public string Name
		{
			set
			{
				this.name = value;
			}
			get
			{
				return this.name != null?  this.name : "";
			}
}
		private string trackEdge;
		[XmlAttribute(AttributeName = "trackEdge")]
		public string TrackEdge
		{
			set
			{
				this.trackEdge = value;
			}
			get
			{
				return this.trackEdge != null?  this.trackEdge : "";
			}
}
		[XmlAttribute]
		public uint pos;
		private string fromCountryCode;
		[XmlAttribute(AttributeName = "fromCountryCode")]
		public string FromCountryCode
		{
			set
			{
				this.fromCountryCode = value;
			}
			get
			{
				return this.fromCountryCode != null?  this.fromCountryCode : "";
			}
}
		private string toCountryCode;
		[XmlAttribute(AttributeName = "toCountryCode")]
		public string ToCountryCode
		{
			set
			{
				this.toCountryCode = value;
			}
			get
			{
				return this.toCountryCode != null?  this.toCountryCode : "";
			}
}

	}
}
