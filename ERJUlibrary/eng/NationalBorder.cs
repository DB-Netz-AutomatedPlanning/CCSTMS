using System;
using System.Runtime.InteropServices;
using System.Xml.Serialization;
namespace eng
{
	[XmlRoot(Namespace = "https://erju.org/eng", ElementName = "nationalBorder")]
	public struct NationalBorder
	{		
		[XmlAttribute]
		private string id;
		[XmlAttribute(AttributeName = "id")]
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
		[XmlAttribute]
		private string countryCode;
		[XmlAttribute(AttributeName = "countryCode")]
		public string CountryCode
        {
            set
            {
                this.countryCode = value;
            }
            get
            {
                return this.countryCode != null ? this.countryCode : "";   
            }
        
        }
	}
}