using System.Xml.Serialization;
using System.Collections.Generic;
namespace ato
{
	[XmlRoot(Namespace = "https://erju.org/ato", ElementName = "voltageType")]
	public enum VoltageType
	{
		vtUnknown,
		vtAC25kv50Hz,
		vtAC15kv16_7Hz,
		vtDC3kv,
		vtDC1_5kv,
		vtDC600_750v,
	}
}
