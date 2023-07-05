using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace infra
{
    public class StopLocationRef
    {
        [XmlIgnore]
        private string? _ref;
        [XmlAttribute(AttributeName = "ref")]
        public string Ref
        {
            set
            {
                this._ref = value;
            }
            get
            {
                return this._ref != null ? this._ref : "";
            }

        }
    }
}
