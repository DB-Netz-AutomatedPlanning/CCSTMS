using System.Xml.Serialization;
using System.Collections.Generic;
namespace tp
{
	[XmlRoot(Namespace = "https://erju.org/tp", ElementName = "protectedInfraElement")]
	public class ProtectedInfraElement
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
                return this.simplePoint != null?  this.simplePoint : "";   
            }
        
        }		
		private string crossing;
		[XmlAttribute(AttributeName = "crossing")]
		public string Crossing
        {
            set
            {
                this.crossing = value;
            }
            get
            {
                return this.crossing != null?  this.crossing : "";   
            }
        
        }		
		private string derailer;
		[XmlAttribute(AttributeName = "derailer")]
		public string Derailer
        {
            set
            {
                this.derailer = value;
            }
            get
            {
                return this.derailer != null?  this.derailer : "";   
            }
        
        }		
		private string levelCrossing;
		[XmlAttribute(AttributeName = "levelCrossing")]
		public string LevelCrossing
        {
            set
            {
                this.levelCrossing = value;
            }
            get
            {
                return this.levelCrossing != null?  this.levelCrossing : "";   
            }
        
        }
	}
}
