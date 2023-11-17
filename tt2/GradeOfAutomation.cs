using System.Xml.Serialization;
namespace tt2
{
	[XmlRoot(Namespace = "https://erju.org/infra", ElementName = "gradeOfAutomation")]
	public enum GradeOfAutomation
	{
		GoA1,
		GoA2,
		GoA3,
		GoA4,
	}
}