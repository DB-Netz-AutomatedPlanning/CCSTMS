using System;
using System.Runtime.InteropServices;
using System.Xml.Serialization;
	[XmlRoot(Namespace = "https://erju.org/", ElementName = "validityPeriod")]
	public class ValidityPeriod
	{		
		[XmlAttribute]
		public uint t_vbc;
}