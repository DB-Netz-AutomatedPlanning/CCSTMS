using System.Xml.Serialization;
using System.Collections.Generic;

namespace ato
{
	[XmlRoot(Namespace = "https://erju.org/ato", ElementName = "timingPoint")]
	public class TimingPoint
	{
		[XmlAttribute]
		public string name {get;set;}
		[XmlAttribute]
		public uint pos {get;set;}
		[XmlAttribute]
		public uint nidTP {get;set;}
		[XmlAttribute]
		public uint stopLocationTolerance {get;set;}
		[XmlAttribute]
		public uint stoppingPointReachDistance {get;set;}
	}
}