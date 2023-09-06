using System;
using System.Runtime.InteropServices;
using System.Xml.Serialization;
namespace eng
{
    [XmlRoot(Namespace = "https://erju.org/eng", ElementName = "crossing")]
    public class Crossing
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
        [XmlArrayItem("dangerPoint", Namespace = "https://erju.org/eng")]
        public List<DangerPointRef>? dangerPoints;
    }
}
