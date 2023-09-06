using System.Xml.Serialization;
using System.Collections.Generic;
namespace eng
{
	[XmlRoot(Namespace = "https://erju.org/eng", ElementName = "trackEdge")]
	public class TrackEdgeRef
	{
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
