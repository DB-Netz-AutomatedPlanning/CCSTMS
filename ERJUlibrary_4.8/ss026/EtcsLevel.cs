using System.Xml.Serialization;
namespace ss026
{
	[XmlRoot(Namespace = "https://erju.org/ss026", ElementName = "etcsLevel")]
	public enum EtcsLevel
	{
		Level0,
		LevelNTC,
		Level1,
		Level2,
		Level3,
		spare
	}
}
