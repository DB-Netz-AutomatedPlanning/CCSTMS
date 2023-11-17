using System.Xml.Serialization;
namespace ato
{
	[XmlRoot(Namespace = "https://erju.org/infra", ElementName = "voltageType")]
	public enum VoltageType
	{
		vtNotFitted,
		vtAC25kv50Hz,
		vtAC15kv16_7Hz,
		vtDC3kv,
		vtDC1_5kv,
		vtDC600_750v,
	}
}