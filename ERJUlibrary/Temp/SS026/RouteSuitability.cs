using System;
using System.Runtime.InteropServices;
using System.Xml.Serialization;
	[XmlRoot(Namespace = "https://erju.org/", ElementName = "routeSuitability")]
	public class RouteSuitability
	{		
		[XmlAttribute]
		public uint loadingGauge;		
		[XmlAttribute]
		public uint maxAxleLoad;		
		public TractionSystem? voltage;
}