using System.Xml.Serialization;
using System.Collections.Generic;
namespace infra
{
	[XmlRoot(Namespace = "https://erju.org/infra", ElementName = "cantDeficiencyCategory")]
	public enum CantDeficiencyCategory
	{
		[XmlEnum(Name = "80mm")]
		_80mm,
        [XmlEnum(Name = "100mm")]
        _100mm,
        [XmlEnum(Name = "130mm")]
        _130mm,
		[XmlEnum(Name = "150mm")] 
		_150mm,
		[XmlEnum(Name = "165mm")] 
		_165mm,
		[XmlEnum(Name = "180mm")] 
		_180mm,
		[XmlEnum(Name = "210mm")] 
		_210mm,
		[XmlEnum(Name = "225mm")] 
		_225mm,
		[XmlEnum(Name = "245mm")] 
		_245mm,
		[XmlEnum(Name = "275mm")] 
		_275mm,
		[XmlEnum(Name = "300mm")] 
		_300mm,
	}
}
