using System.Xml.Serialization;
namespace ato
{
	[XmlRoot(Namespace = "https://erju.org/infra", ElementName = "trainEndApplicability")]
	public enum TrainEndApplicability
	{
		trainFront,
		trainBack,
	}
}