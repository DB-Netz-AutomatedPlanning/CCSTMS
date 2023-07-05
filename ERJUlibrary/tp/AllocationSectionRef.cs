using System;
using System.Runtime.InteropServices;
using System.Xml.Serialization;
namespace tp
{
    [XmlRoot(Namespace = "https://erju.org/tp", ElementName = "allocationSection")]
    public class AllocationSectionRef
    {
        [XmlAttribute]
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