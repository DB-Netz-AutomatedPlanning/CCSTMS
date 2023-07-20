using System;
using System.Runtime.InteropServices;
using System.Xml.Serialization;
	[XmlRoot(Namespace = "https://erju.org/", ElementName = "mAMode")]
	public enum MAMode
	{
		MAM_OS,
		MAM_LS,
		MAM_SH,
		MAM_other,
}