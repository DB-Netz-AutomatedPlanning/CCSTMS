using System;
using System.Runtime.InteropServices;
using System.Xml.Serialization;
namespace topo
{
	[XmlRoot(Namespace = "https://erju.org/topo", ElementName = "functionalArea")]
	public struct FunctionalArea
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
        [XmlArrayItem("opPoint", Namespace = "https://erju.org/topo")]
        public List<OperationalPoint> opPoints;
        [XmlArrayItem("timingPoint", Namespace = "https://erju.org/topo")]
        public List<TimingPoint> timingPoints;
        [XmlArrayItem("simplePoint", Namespace = "https://erju.org/topo")]
        public List<SimplePoint> simplePoints;
        [XmlArrayItem("slipCrossing", Namespace = "https://erju.org/topo")]
        public List<SlipCrossing> slipCrossings;
        [XmlArrayItem("derailer", Namespace = "https://erju.org/topo")]
        public List<Derailer> derailers;
        [XmlArrayItem("crossing", Namespace = "https://erju.org/topo")]
        public List<Crossing> crossings;
        [XmlArrayItem("baliseGroup", Namespace = "https://erju.org/topo")]
        public List<BaliseGroup> baliseGroups;
	}
}