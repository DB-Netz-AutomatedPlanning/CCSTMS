using System.Xml.Serialization;
namespace ss026
{
	[XmlRoot(Namespace = "https://erju.org/ss026", ElementName = "displayOperatingLevel")]
	public enum DisplayOperatingLevel
	{
		DOL_level0,
		DOL_levelNTC,
		DOL_level1,
		DOL_level2,
		DOL_level3,
		DOL_notLimited,
		DOL_spare
	}
}
