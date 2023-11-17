using System.Xml.Serialization;
namespace infra
{
	[XmlRoot(Namespace = "https://erju.org/infra", ElementName = "axleLoadCategory")]
	public enum AxleLoadCategory
	{
		AL_A,
		AL_HS17,
		AL_B1,
		AL_C2,
		AL_C3,
		AL_C4,
		AL_D2,
		AL_D3,
		AL_D4,
		AL_D4XL,
		AL_E4,
		AL_E5,
	}
}