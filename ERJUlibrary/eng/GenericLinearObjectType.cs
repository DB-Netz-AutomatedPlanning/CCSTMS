using System;
using System.Runtime.InteropServices;
using System.Xml.Serialization;
namespace eng
{
	[XmlRoot(Namespace = "https://erju.org/eng", ElementName = "genericLinearObjectType")]
	public enum GenericLinearObjectType
	{
		wall,
		handRail,
		cableDuct,
		platform,
	}
}