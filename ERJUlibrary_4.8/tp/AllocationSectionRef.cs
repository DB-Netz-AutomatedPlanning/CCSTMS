using System.Xml.Serialization;
using System.Collections.Generic;
namespace tp
{
    [XmlRoot(Namespace = "https://erju.org/tp", ElementName = "allocationSection")]
    public class AllocationSectionRef
    {
        [XmlAttribute]
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
