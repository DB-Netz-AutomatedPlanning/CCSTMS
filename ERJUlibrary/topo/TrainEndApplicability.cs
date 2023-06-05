using System;
using System.Runtime.InteropServices;
using System.Xml.Serialization;
namespace topo
{
	[XmlRoot(Namespace = "https://erju.org/topo", ElementName = "trainEndApplicability")]
	public enum TrainEndApplicability
	{
		lengthDelay,
		noLengthDelay,
	}
}