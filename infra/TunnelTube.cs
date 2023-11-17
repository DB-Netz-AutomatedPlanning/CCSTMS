﻿using System.Xml.Serialization;
using System.Collections.Generic;

namespace infra
{
	[XmlRoot(Namespace = "https://erju.org/infra", ElementName = "tunnelTube")]
	public class TunnelTube
	{
		[XmlArrayItem("trackSection", Namespace = "https://erju.org/infra")]
		public List<infra.TrackEdgeSection> trackSections;
		[XmlAttribute]
		public uint crossSection {get;set;}
	}
}