using System;
using System.Runtime.InteropServices;
using System.Xml.Serialization;
	[XmlRoot(Namespace = "https://erju.org/", ElementName = "etcsLevel")]
	public enum EtcsLevel
	{
		Level0,
		LevelNTC,
		Level1,
		Level2,
		Level3,
		other,
}