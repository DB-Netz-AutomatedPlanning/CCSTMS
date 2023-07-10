using System;
using System.Runtime.InteropServices;
using System.Xml.Serialization;
	[XmlRoot(Namespace = "https://erju.org/", ElementName = "platformPosition")]
	public enum PlatformPosition
	{
		left,
		right,
		both,
		spare,
}