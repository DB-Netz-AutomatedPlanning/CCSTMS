using System;
using System.Runtime.InteropServices;
using System.Xml.Serialization;
namespace tp
{
	[XmlRoot(Namespace = "https://erju.org/tp", ElementName = "trainProtection")]
	public class TrainProtection
	{		
		[XmlArrayItem("trainProtectionArea", Namespace = "https://erju.org/tp")]
		public List<TrainProtectionArea>? tpArea;
	}
}