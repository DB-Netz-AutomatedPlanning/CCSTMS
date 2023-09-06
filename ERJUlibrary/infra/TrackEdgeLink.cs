using System.Xml.Serialization;
using System.Collections.Generic;
namespace infra
{
	[XmlRoot(Namespace = "https://erju.org/infra", ElementName = "trackEdgeLink")]
	public class TrackEdgeLink
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
		private string trackEdgeA;
		[XmlAttribute(AttributeName = "trackEdgeA")]
		public string TrackEdgeA
		{
			set
			{
				this.trackEdgeA = value;
			}
			get
			{
				return this.trackEdgeA != null?  this.trackEdgeA : "";
			}
}
		private string trackEdgeB;
		[XmlAttribute(AttributeName = "trackEdgeB")]
		public string TrackEdgeB
		{
			set
			{
				this.trackEdgeB = value;
			}
			get
			{
				return this.trackEdgeB != null?  this.trackEdgeB : "";
			}
}
		[XmlAttribute]
		public bool startOfA;
		[XmlAttribute]
		public bool startOfB;
		[XmlAttribute]
		public LinkDirection usableDir;

	}
}
