using System; using System.Xml.Serialization;

using System.Linq;
using System.Text;
using System.Threading.Tasks;
 

namespace infra
{
    public class StopLocationRef
    {
        [XmlIgnore]
        private string _ref;
        [XmlAttribute(AttributeName = "ref")]
        public string Ref
        {
            set
            {
                this._ref = value;
            }
            get
            {
                return this._ref != null?  this._ref : "";
            }

        }
    }
}
