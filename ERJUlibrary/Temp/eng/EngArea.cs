using System;
using System.Runtime.InteropServices;
using System.Xml.Serialization;
namespace eng
{
	[XmlRoot(Namespace = "https://erju.org/eng", ElementName = "engArea")]
	public class EngArea
	{		
		[XmlAttribute]
		private string? id;
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
        public SleepersType defaultSpeelersType;
        [XmlArrayItem("simplePoint", Namespace = "https://erju.org/eng")]
        public List<SimplePoint>? simplePoints;
        [XmlArrayItem("crossing", Namespace = "https://erju.org/eng")]
        public List<Crossing>? crossings;
        [XmlArrayItem("levelCrossing", Namespace = "https://erju.org/eng")]
        public List<LevelCrossing>? levelCrossings;
        [XmlArrayItem("balise", Namespace = "https://erju.org/eng")]
        public List<Balise>? balises;
        [XmlArrayItem("sleepers", Namespace = "https://erju.org/eng")]
        public List<Sleepers>? sleepers;
        [XmlArrayItem("dangerPoint", Namespace = "https://erju.org/eng")]
        public List<DangerPoint>? dangerPoints;
        [XmlArrayItem("bufferStop", Namespace = "https://erju.org/eng")]
        public List<BufferStop>? bufferStops;
    }
}