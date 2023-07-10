using System;
using System.Runtime.InteropServices;
using System.Xml.Serialization;
	[XmlRoot(Namespace = "https://erju.org/", ElementName = "qDir")]
	public enum QDir
	{
		reverse,
		nominal,
		both,
		spare,
}