using System;
using System.Runtime.InteropServices;
using System.Xml.Serialization;
	[XmlRoot(Namespace = "https://erju.org/", ElementName = "eTCSVersion")]
	public enum ETCSVersion
	{
		v1_0,
		v1_1,
		v2_0,
		v2_1,
		previous,
		reserved,
		invalid,
}