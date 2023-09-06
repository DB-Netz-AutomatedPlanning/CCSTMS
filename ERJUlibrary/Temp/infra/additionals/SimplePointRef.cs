using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace infra
{
    public class SimplePointRef
    {
        [XmlIgnore]
        private string? _ref;
        [XmlAttribute(AttributeName = "ref")]
        public string Ref
        {
            set
            {
                _ref = value;
            }
            get
            {
                return _ref != null ? _ref : "";
            }

        }
    }
}
