using System;
using System.Runtime.InteropServices;
using System.Xml.Serialization;
	[XmlRoot(Namespace = "https://erju.org/", ElementName = "pBDSelection")]
	public class PBDSelection
	{		
		[XmlArrayItem("permittedBrakingDist", Namespace = "https://erju.org/")]
		public List<PermittedBrakingDist>? pbds;		
		[XmlAttribute]
		public uint d_trackinit;
}