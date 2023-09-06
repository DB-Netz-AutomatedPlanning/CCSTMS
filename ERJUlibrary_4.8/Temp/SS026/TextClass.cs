using System;
using System.Runtime.InteropServices;
using System.Xml.Serialization;
	[XmlRoot(Namespace = "https://erju.org/", ElementName = "textClass")]
	public enum TextClass
	{
		auxiliary,
		important,
		other,
}