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
		public List<OperationalPoint> opPoints;		
		public List<TimingPoint> timingPoints;		
		public List<SimplePoint> simplePoints;		
		public List<SlipCrossing> slipCrossings;		
		public List<Derailer> derailers;		
		public List<Crossing> crossings;		
		public List<BaliseGroup> baliseGroups;
	}
}