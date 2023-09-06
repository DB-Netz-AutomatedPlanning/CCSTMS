using System.Xml.Serialization;
using System.Collections.Generic;
namespace infra
{
	[XmlRoot(Namespace = "https://erju.org/infra", ElementName = "dirTrackEdge")]
	public class DirTrackEdge
	{
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
		public bool sameDir;

	}
}
