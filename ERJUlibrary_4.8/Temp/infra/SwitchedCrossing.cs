using infra;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace ERJUlibrary_4._8.infra
{
    public class SwitchedCrossing
    {
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
                return this.name != null ? this.name : "";
            }

        }

        [XmlArrayItem("trackEdgeLink", Namespace = "https://erju.org/infra")]
        public List<TrackEdgeLinkRef> trackedgelinks;
    }
}
