using System;
using System.Runtime.InteropServices;
using System.Xml.Serialization;
namespace eng
{
	[XmlRoot(Namespace = "https://erju.org/eng", ElementName = "route")]
	public struct Route
	{		
		[XmlAttribute]
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
		public List<string> tvps;		
		private string routeStartLocation;
		[XmlAttribute(AttributeName = "routeStartLocation")]
		public string RouteStartLocation
        {
            set
            {
                this.routeStartLocation = value;
            }
            get
            {
                return this.routeStartLocation != null ? this.routeStartLocation : "";   
            }
        
        }		
		public List<string> routeIntermediateLocation;		
		private string routeStopLocation;
		[XmlAttribute(AttributeName = "routeStopLocation")]
		public string RouteStopLocation
        {
            set
            {
                this.routeStopLocation = value;
            }
            get
            {
                return this.routeStopLocation != null ? this.routeStopLocation : "";   
            }
        
        }
	}
}