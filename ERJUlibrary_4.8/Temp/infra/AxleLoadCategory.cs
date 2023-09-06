using System.Xml.Serialization;
using System.Collections.Generic;
namespace infra
{
	[XmlRoot(Namespace = "https://erju.org/infra", ElementName = "axleLoadCategory")]
	public enum AxleLoadCategory
	{
		A,
		HS17,
		B1,
		C2,
		C3,
		C4,
		D2,
		D3,
		D4,
		D4XL,
		E4,
		E5,
	}
}
