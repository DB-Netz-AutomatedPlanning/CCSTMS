using System;
using System.Runtime.InteropServices;
using System.Xml.Serialization;
namespace infra
{
	[XmlRoot(Namespace = "https://erju.org/infra", ElementName = "funcElementRef")]
	public class FuncElementRef
	{		
		private string? simplePoint;
		[XmlAttribute(AttributeName = "simplePoint")]
		public string SimplePoint
        {
            set
            {
                this.simplePoint = value;
            }
            get
            {
                return this.simplePoint != null ? this.simplePoint : "";   
            }
        
        }		
		private string? etcsMarker;
		[XmlAttribute(AttributeName = "etcsMarker")]
		public string EtcsMarker
        {
            set
            {
                this.etcsMarker = value;
            }
            get
            {
                return this.etcsMarker != null ? this.etcsMarker : "";   
            }
        
        }		
		private string? stopLocation;
		[XmlAttribute(AttributeName = "stopLocation")]
		public string StopLocation
        {
            set
            {
                this.stopLocation = value;
            }
            get
            {
                return this.stopLocation != null ? this.stopLocation : "";   
            }
        
        }		
		private string? timingPoint;
		[XmlAttribute(AttributeName = "timingPoint")]
		public string TimingPoint
        {
            set
            {
                this.timingPoint = value;
            }
            get
            {
                return this.timingPoint != null ? this.timingPoint : "";   
            }
        
        }		
		private string? operationalPoint;
		[XmlAttribute(AttributeName = "operationalPoint")]
		public string OperationalPoint
        {
            set
            {
                this.operationalPoint = value;
            }
            get
            {
                return this.operationalPoint != null ? this.operationalPoint : "";   
            }
        
        }		
		private string? balise;
		[XmlAttribute(AttributeName = "balise")]
		public string Balise
        {
            set
            {
                this.balise = value;
            }
            get
            {
                return this.balise != null ? this.balise : "";   
            }
        
        }

        private string? trainDetector;
        [XmlAttribute(AttributeName = "trainDetector")]
        public string TrainDetector
        {
            set
            {
                this.trainDetector = value;
            }
            get
            {
                return this.trainDetector != null ? this.trainDetector : "";
            }
        }
    }
}