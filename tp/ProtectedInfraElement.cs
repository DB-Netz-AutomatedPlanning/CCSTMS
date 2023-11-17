using System.Xml.Serialization;
using System.Collections.Generic;

namespace tp
{
	[XmlRoot(Namespace = "https://erju.org/tp", ElementName = "protectedInfraElement")]
	public class ProtectedInfraElement
	{
		public SimplePointRef? simplePoint {get;set;}
		public SlipCrossingRef? slipCrossing {get;set;}
		public CrossingRef? crossing {get;set;}
		public DerailerRef? derailer {get;set;}
		public LevelCrossingRef? levelCrossing {get;set;}
	}
}