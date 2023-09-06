using System;
using System.Runtime.InteropServices;
using System.Xml.Serialization;
	[XmlRoot(Namespace = "https://erju.org/", ElementName = "platformType")]
	public enum PlatformType
	{
		_200,
		_300_380,
		_550,
		_580,
		_680,
		_685,
		_730,
		_760,
		_840,
		_900,
		_915,
		_920,
		_960,
		_1100,
		other,
}