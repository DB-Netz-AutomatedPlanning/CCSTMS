using System;
using System.Runtime.InteropServices;
using System.Xml.Serialization;
	[XmlRoot(Namespace = "https://erju.org/", ElementName = "voltageType")]
	public enum VoltageType
	{
		VT_none,
		VT_1,
		VT_2,
		VT_3,
		VT_4,
		VT_5,
		VT_Spare,
}