﻿using System.Xml.Serialization;
using System.Collections.Generic;

namespace infra
{
	[XmlRoot(Namespace = "https://erju.org/infra", ElementName = "verticalLine")]
	public class VerticalLine
	{
		[XmlAttribute]
		public double pos {get;set;}
		[XmlAttribute]
		public double slope {get;set;}
	}
}