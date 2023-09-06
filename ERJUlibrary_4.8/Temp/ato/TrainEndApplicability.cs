using System.Xml.Serialization;
using System.Collections.Generic;
namespace ato
{
	[XmlRoot(Namespace = "https://erju.org/ato", ElementName = "trainEndApplicability")]
	public enum TrainEndApplicability
	{
		trainFront,
		trainBack,
	}
}
