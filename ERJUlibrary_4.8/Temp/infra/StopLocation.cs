using System.Xml.Serialization;
using System.Collections.Generic;
using ERJUlibrary_4._8.infra;

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
        private string trackEdge;
        [XmlAttribute(AttributeName = "trackEdge")]
        public string TrackEdge
        {
            set
            {
                this.trackEdge = value;
            }
            get
            {
                return this.trackEdge != null ? this.trackEdge : "";
            }

        }
        [XmlAttribute]
        public uint pos;
        [XmlAttribute]
        public bool sameDir;
        public TimingPoint timingPoint;		
		public TrainLoadType trainLoadType;
        public DoorOpeningSide doorOpeningSide;
        [XmlArrayItem("stopTrainLimit", Namespace = "https://erju.org/infra")]
        public List<StopTrainLimit> stopTrainLimit;
    }
}
