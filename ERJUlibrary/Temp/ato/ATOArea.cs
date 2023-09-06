using System;
using System.Runtime.InteropServices;
using System.Xml.Serialization;
namespace ato
{
	[XmlRoot(Namespace = "https://erju.org/ato", ElementName = "aTOArea")]
	public class ATOArea
	{		
		[XmlAttribute]
		private string? id;
		[XmlAttribute(AttributeName = "atoTSId")]
		public string Id
        {
            set
            {
                this.id = value;
            }
            get
            {
                return this.id != null ? this.id : "";   
            }
        
        }		
		[XmlArrayItem("aTOSegment", Namespace = "https://erju.org/ato")]
		public List<ATOSegment>? segments;
	}
}