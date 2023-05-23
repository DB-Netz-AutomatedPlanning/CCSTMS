using System;
using System.Runtime.InteropServices;
using System.Xml.Serialization;
namespace topo
{
	[XmlRoot(Namespace = "https://erju.org/topo", ElementName = "funcElementProjection")]
	public struct FuncElementProjection
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