using System;
using System.Runtime.InteropServices;
using System.Xml.Serialization;
namespace infra
{
	[XmlRoot(Namespace = "https://erju.org/infra", ElementName = "nationalBorder")]
	public class NationalBorder
    {
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
        public TrackEdgePoint? trackEdgePoint;		

		private string? fromCountryCode;
        [XmlAttribute(AttributeName = "fromCountryCode")]
        public string FromCountryCode
        {
            set
            {
                this.fromCountryCode = value;
            }
            get
            {
                return this.fromCountryCode != null ? this.fromCountryCode : "";
            }

        }

        private string? toCountryCode;
        [XmlAttribute(AttributeName = "toCountryCode")]
        public string ToCountryCode
        {
            set
            {
                this.toCountryCode = value;
            }
            get
            {
                return this.toCountryCode != null ? this.toCountryCode : "";
            }

        }


    }
}