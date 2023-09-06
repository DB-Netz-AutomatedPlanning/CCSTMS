using System.Xml.Serialization;
using System.Collections.Generic;
namespace infra
{
	[XmlRoot(Namespace = "https://erju.org/infra", ElementName = "operationalPoint")]
	public class OperationalPoint
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
		[XmlArrayItem("travelTimeMeasurementPoint", Namespace = "https://erju.org/infra")]
		public List<TimingPointRef> travelTimeMeasurementPoints;
		[XmlAttribute]
		public OPType type;
		[XmlArrayItem("platform", Namespace = "https://erju.org/infra")]
		public List<Platform> platforms;

	}
}
