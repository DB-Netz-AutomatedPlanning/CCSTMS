using System.Xml.Serialization;
namespace ss026
{
	[XmlRoot(Namespace = "https://erju.org/infra", ElementName = "axleLoadCategory")]
	public enum AxleLoadCategory
	{
		A,
		HS17,
		B1,
		B2,
		C2,
		C3,
		C4,
		D2,
		D3,
		D4,
		D4XL,
		E4,
		E5,
		ALC_spare,
	}
}