using System.Xml.Serialization;
using System.Collections.Generic;
namespace infra
{
	[XmlRoot(Namespace = "https://erju.org/infra", ElementName = "funcElementProjection")]
	public class FuncElementProjection
	{
		public FuncElementRef elementRef;
		[XmlAttribute]
		public double x;
		[XmlAttribute]
		public double y;
		[XmlAttribute]
		public double z;

	}
}
