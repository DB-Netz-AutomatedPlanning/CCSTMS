using System;
using System.Runtime.InteropServices;
using System.Xml.Serialization;
	[XmlRoot(Namespace = "https://erju.org/", ElementName = "axleLoadSelection")]
	public class AxleLoadSelection
	{		
		public AxleLoad? axleLoad;		
		[XmlAttribute]
		public uint d_trackinit;
}