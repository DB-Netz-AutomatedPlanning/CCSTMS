using System.Xml.Serialization;
using System.Collections.Generic;
namespace eng
{
	[XmlRoot(Namespace = "https://erju.org/eng", ElementName = "sleepers")]
	public class Sleepers
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
		[XmlArrayItem("trackEdgeSectionItem", Namespace = "https://erju.org/eng")]
		public List<infra.TrackEdgeSection> trackEdgeSection;
		[XmlAttribute]
		public SleepersType type;

	}
}
