using System.Xml.Serialization;
namespace tt
{
	[XmlRoot(Namespace = "https://erju.org/infra", ElementName = "alignmentType")]
	public enum AlignmentType
	{
		HEAD,
		CENTER,
		REAR,
	}
}