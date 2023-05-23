using System;
using System.Runtime.InteropServices;
using System.Xml.Serialization;
namespace topo
{
	[XmlRoot(Namespace = "https://erju.org/topo", ElementName = "direction")]
	public enum Direction
	{
		both,
		endToStart,
		startToEnd,
	}
}