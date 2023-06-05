using System;
using System.Runtime.InteropServices;
using System.Xml.Serialization;
namespace eng
{
	[XmlRoot(Namespace = "https://erju.org/eng", ElementName = "eTCSlevel")]
	public enum ETCSlevel
	{
		level0,
		level1,
		level2,
		level3,
		levelSTM,
	}
}