using System.Xml.Serialization;
namespace ss026
{
	[XmlRoot(Namespace = "https://erju.org/infra", ElementName = "voltageType")]
	public enum VoltageType
	{
		VT_none,
		VT_1,
		VT_2,
		VT_3,
		VT_4,
		VT_5,
		VT_Spare,
	}
}