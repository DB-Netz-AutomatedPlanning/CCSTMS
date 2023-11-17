using System.Xml.Serialization;
using System.Collections.Generic;

namespace infra
{
	[XmlRoot(Namespace = "https://erju.org/infra", ElementName = "stopLocation")]
	public class StopLocation
	{
		public infra.StopTrainLimit? stopTrainLimit {get;set;}
		[XmlAttribute]
		public string id {get;set;}
		[XmlAttribute]
		public string trackEdge {get;set;}
		[XmlAttribute]
		public uint pos {get;set;}
		[XmlAttribute]
		public bool sameDir {get;set;}
		[XmlAttribute]
		public string timingPoint {get;set;}
		[XmlAttribute]
		public infra.TrainLoadType trainLoadType {get;set;}
		[XmlAttribute]
		public infra.DoorOpeningSide doorOpeningSide {get;set;}
	}
}