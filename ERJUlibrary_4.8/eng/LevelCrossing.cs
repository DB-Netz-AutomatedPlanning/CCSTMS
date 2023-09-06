using System.Xml.Serialization;
using System.Collections.Generic;
namespace eng
{
	[XmlRoot(Namespace = "https://erju.org/eng", ElementName = "levelCrossing")]
	public class LevelCrossing
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
		[XmlArrayItem("dangerPoint", Namespace = "https://erju.org/eng")]
		public List<DangerPointRef> dangerPoints;

	}
}
