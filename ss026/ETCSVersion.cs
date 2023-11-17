using System.Xml.Serialization;
namespace ss026
{
	[XmlRoot(Namespace = "https://erju.org/infra", ElementName = "eTCSVersion")]
	public enum ETCSVersion
	{
		v1_0,
		v1_1,
		v2_0,
		v2_1,
		v_previous,
		v_reserved,
		v_invalid,
	}
}