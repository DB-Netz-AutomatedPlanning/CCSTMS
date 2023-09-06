using System;
using System.Runtime.InteropServices;
using System.Xml.Serialization;
namespace ato
{
	[XmlRoot(Namespace = "https://erju.org/ato", ElementName = "rangeType")]
	public enum RangeType
	{
		rtStart,
		rtEnd,
		rtStartEnd,
		rtWholeSP,
	}
}