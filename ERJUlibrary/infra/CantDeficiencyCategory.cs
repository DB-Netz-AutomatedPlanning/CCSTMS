using System.Xml.Serialization;
namespace infra
{
	[XmlRoot(Namespace = "https://erju.org/infra", ElementName = "cantDeficiencyCategory")]
	public enum CantDeficiencyCategory
	{
		CD_80mm,
		CD_100mm,
		CD_130mm,
		CD_150mm,
		CD_165mm,
		CD_180mm,
		CD_210mm,
		CD_225mm,
		CD_245mm,
		CD_275mm,
		CD_300mm
	}
}
