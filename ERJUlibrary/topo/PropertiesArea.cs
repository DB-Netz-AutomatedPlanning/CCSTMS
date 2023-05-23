using System;
using System.Runtime.InteropServices;
using System.Xml.Serialization;
namespace topo
{
	[XmlRoot(Namespace = "https://erju.org/topo", ElementName = "propertiesArea")]
	public struct PropertiesArea
	{		
		[XmlAttribute]
		private string areaId;
		[XmlAttribute(AttributeName = "areaId")]
		public string AreaId
        {
            set
            {
                this.areaId = value;
            }
            get
            {
                return this.areaId != null ? this.areaId : "";   
            }
        
        }		
		[XmlAttribute]
		public uint gauge;
        [XmlAttribute]
        public LoadingGaugeType loadingGaugeType;		
		public List<TrackEdgeGauge> trackEdgeGauges;		
		public List<TrackEdgeLoadingGauge> trackEdgeLoadingGauges;		
		public List<TrackCondition> trackConditions;
	}
}