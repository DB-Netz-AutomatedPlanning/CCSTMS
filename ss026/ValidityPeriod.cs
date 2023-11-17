using System.Xml.Serialization;
using System.Collections.Generic;

namespace ss026
{
	[XmlRoot(Namespace = "https://erju.org/ss026", ElementName = "validityPeriod")]
	public class ValidityPeriod
	{
		[XmlAttribute]
		public uint t_vbc {get;set;}
	}
}