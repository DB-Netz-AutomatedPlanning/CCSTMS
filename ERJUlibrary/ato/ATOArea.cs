using System;
using System.Runtime.InteropServices;
using System.Xml.Serialization;
namespace ato
{
	[XmlRoot(Namespace = "https://erju.org/ato", ElementName = "aTOArea")]
	public class ATOArea
	{		
		[XmlAttribute]
		private string? atoTSId;
		[XmlAttribute(AttributeName = "atoTSId")]
		public string AtoTSId
        {
            set
            {
                this.atoTSId = value;
            }
            get
            {
                return this.atoTSId != null ? this.atoTSId : "";   
            }
        
        }		
		[XmlArrayItem("aTOSegment", Namespace = "https://erju.org/ato")]
		public List<ATOSegment>? segments;
	}
}