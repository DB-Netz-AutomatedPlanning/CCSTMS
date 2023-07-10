using System;
using System.Runtime.InteropServices;
using System.Xml.Serialization;
	[XmlRoot(Namespace = "https://erju.org/", ElementName = "displayOperatingLevel")]
	public enum DisplayOperatingLevel
	{
		level0,
		levelNTC,
		level1,
		level2,
		level3,
		notLimited,
		spare,
}