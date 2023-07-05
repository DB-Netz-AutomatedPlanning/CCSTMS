using System;
using System.Runtime.InteropServices;
using System.Xml.Serialization;
namespace infra
{
	[XmlRoot(Namespace = "https://erju.org/infra", ElementName = "secondaryTrack")]
	public class SecondaryTrackRef
    {
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

        }    		}
}