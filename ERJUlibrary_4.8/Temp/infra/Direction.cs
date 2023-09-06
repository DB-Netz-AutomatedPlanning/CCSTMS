using System.Xml.Serialization;
using System.Collections.Generic;
namespace infra
{
	[XmlRoot(Namespace = "https://erju.org/infra", ElementName = "direction")]
	public enum Direction
	{
		both,
		endToStart,
		startToEnd,
	}
}
