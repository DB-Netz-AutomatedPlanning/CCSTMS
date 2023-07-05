using System.Xml.Serialization;
using System.Collections.Generic;
namespace infra
{
	[XmlRoot(Namespace = "https://erju.org/infra", ElementName = "stopLocation")]
	public class StopLocation
	{		
		[XmlAttribute]
		public uint id;		
		[XmlAttribute]
		private string name;
		[XmlAttribute(AttributeName = "name")]
		public string Name
        {
            set
            {
                this.name = value;
            }
            get
            {
                return this.name != null?  this.name : "";   
            }
        
        }		
		public TrackEdgePoint trackEdgePoint;		
		public StopTrainLimit stopTrainLimit;
	}
}
