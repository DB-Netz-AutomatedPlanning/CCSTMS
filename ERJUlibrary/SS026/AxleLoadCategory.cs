using System;
using System.Runtime.InteropServices;
using System.Xml.Serialization;
	[XmlRoot(Namespace = "https://erju.org/", ElementName = "axleLoadCategory")]
	public enum AxleLoadCategory
	{
		A,
		HS17,
		B1,
		B2,
		C2,
		C3,
		C4,
		D2,
		D3,
		D4,
		D4XL,
		E4,
		E5,
		spare,
}