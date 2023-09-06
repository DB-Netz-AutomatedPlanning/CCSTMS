using System;
using System.Runtime.InteropServices;
using System.Xml.Serialization;
namespace tp
{
	[XmlRoot(Namespace = "https://erju.org/tp", ElementName = "minimalDrivability")]
	public enum MinimalDrivability
	{
		none,
		full,
		limited,
	}
}