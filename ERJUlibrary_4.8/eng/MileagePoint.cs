using System.Xml.Serialization;
using System.Collections.Generic;
namespace eng
{
	[XmlRoot(Namespace = "https://erju.org/eng", ElementName = "mileagePoint")]
	public class MileagePoint
	{
		[XmlAttribute]
		public double pos;
		[XmlAttribute]
		public double mileage;

	}
}
