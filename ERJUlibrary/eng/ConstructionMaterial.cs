using System;
using System.Runtime.InteropServices;
using System.Xml.Serialization;
namespace eng
{
	[XmlRoot(Namespace = "https://erju.org/eng", ElementName = "constructionMaterial")]
	public enum ConstructionMaterial
	{
		masonry,
		concrete,
		steel,
	}
}