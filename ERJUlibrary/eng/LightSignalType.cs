using System;
using System.Runtime.InteropServices;
using System.Xml.Serialization;
namespace eng
{
	[XmlRoot(Namespace = "https://erju.org/eng", ElementName = "lightSignalType")]
	public enum LightSignalType
	{
		mainSignal,
		shuntingSignal,
	}
}