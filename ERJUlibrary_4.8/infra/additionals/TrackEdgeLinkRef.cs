using System; using System.Xml.Serialization;

using System.Linq;
using System.Text;
using System.Threading.Tasks;
 

namespace infra
{
    public class TrackEdgeLinkRef
    {
        [XmlIgnore]
        private string _ref;
        [XmlAttribute(AttributeName = "ref")]
        public string Ref
        {
            set
            {
                _ref = value;
            }
            get
            {
                return _ref != null?  _ref : "";
            }

        }
    }
}
