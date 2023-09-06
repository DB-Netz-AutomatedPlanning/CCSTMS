using System;
using System.Runtime.InteropServices;
using System.Xml.Serialization;
namespace infra
{
	[XmlRoot(Namespace = "https://erju.org/infra", ElementName = "funcElementProjection")]
	public class FuncElementProjection
	{		
		public FuncElementRef? elementRef;		
		[XmlAttribute]
		public double x;		
		[XmlAttribute]
		public double y;		
		[XmlAttribute]
		public double z;
	}
}