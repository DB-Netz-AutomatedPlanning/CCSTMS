using System.Xml.Serialization;
using System.Collections.Generic;

namespace ss026
{
	[XmlRoot(Namespace = "https://erju.org/ss026", ElementName = "eTCSPacket_51")]
	public class ETCSPacket_51
	{
		public ss026.AxleLoadSelection? axleLoadSelection {get;set;}
	}
}