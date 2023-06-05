using System;
using System.Runtime.InteropServices;
using System.Xml.Serialization;
namespace eng
{
	[XmlRoot(Namespace = "https://erju.org/eng", ElementName = "levelCrossingSupervisionState")]
	public enum LevelCrossingSupervisionState
	{
		camera,
		dispatcher,
		none,
	}
}