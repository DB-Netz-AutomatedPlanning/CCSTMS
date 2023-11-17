using System.Xml.Serialization;
using System.Collections.Generic;

namespace infra
{
	[XmlRoot(Namespace = "https://erju.org/infra", ElementName = "funcElementProjection")]
	public class FuncElementProjection
	{
		public infra.FuncElementRef? elementRef {get;set;}
		[XmlAttribute]
		public double x {get;set;}
		[XmlAttribute]
		public double y {get;set;}
		[XmlAttribute]
		public double z {get;set;}
	}
}