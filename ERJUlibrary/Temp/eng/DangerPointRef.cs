using System;
using System.Runtime.InteropServices;
using System.Xml.Serialization;
using infra;

namespace eng
{
	[XmlRoot(Namespace = "https://erju.org/eng", ElementName = "dangerPoint")]
	public class DangerPointRef
	{		
		[XmlAttribute]
		private string? _ref;
		[XmlAttribute(AttributeName = "ref")]
		public string Ref
        {
            set
            {
                this._ref = value;
            }
            get
            {
                return this._ref != null ? this._ref : "";   
            }
        
        }			
	}
}