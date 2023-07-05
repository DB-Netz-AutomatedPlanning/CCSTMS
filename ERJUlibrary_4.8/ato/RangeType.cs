using System.Xml.Serialization;
using System.Collections.Generic;
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
