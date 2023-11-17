using System.Xml.Serialization;
namespace ato
{
	[XmlRoot(Namespace = "https://erju.org/infra", ElementName = "rangeType")]
	public enum RangeType
	{
		rtStart,
		rtEnd,
		rtStartEnd,
		rtWholeSP,
	}
}