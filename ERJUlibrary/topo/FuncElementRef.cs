using System;
using System.Runtime.InteropServices;
using System.Xml.Serialization;
namespace topo
{
	[XmlRoot(Namespace = "https://erju.org/topo", ElementName = "funcElementRef")]
	public struct FuncElementRef
	{		
		private string simplePoint;
		[XmlAttribute(AttributeName = "simplePoint")]
		public string SimplePoint
        {
            set
            {
                this.simplePoint = value;
            }
            get
            {
                return this.simplePoint != null ? this.simplePoint : "";   
            }
        
        }
	}
}