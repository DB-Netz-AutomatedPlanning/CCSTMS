using System.Xml.Serialization;
using System.Collections.Generic;
namespace infra
{
	[XmlRoot(Namespace = "https://erju.org/infra", ElementName = "trainEndApplicability")]
	public enum TrainEndApplicability
	{
		lengthDelay,
		noLengthDelay,
	}
}
