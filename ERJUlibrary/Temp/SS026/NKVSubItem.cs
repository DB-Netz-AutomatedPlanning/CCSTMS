using System;
using System.Runtime.InteropServices;
using System.Xml.Serialization;
	[XmlRoot(Namespace = "https://erju.org/", ElementName = "nKVSubItem")]
	public class NKVSubItem
	{		
		public NVP13? nvp13;		
		[XmlArrayItem("vMM", Namespace = "https://erju.org/")]
		public List<VMM>? mvvs;
}