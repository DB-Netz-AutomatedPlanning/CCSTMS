using System.Xml.Serialization;
using System.Collections.Generic;

namespace tt2
{
	[XmlRoot(Namespace = "https://erju.org/tt2", ElementName = "passengerTransferActivity")]
	public class PassengerTransferActivity
	{
		[XmlAttribute]
		public string waitingForEvents {get;set;}
		[XmlAttribute]
		public uint transferDuration {get;set;}
	}
}