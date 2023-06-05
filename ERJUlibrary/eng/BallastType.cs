using System;
using System.Runtime.InteropServices;
using System.Xml.Serialization;
namespace eng
{
	[XmlRoot(Namespace = "https://erju.org/eng", ElementName = "ballastType")]
	public enum BallastType
	{
		ballast,
		slabTrack,
	}
}