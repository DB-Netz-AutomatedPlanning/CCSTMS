using System.Xml.Serialization;
namespace eng
{
	[XmlRoot(Namespace = "https://erju.org/eng", ElementName = "duplicationType")]
	public enum DuplicationType
	{
		noDuplicates,
		duplicateNextBalise,
		duplicatePreviousBalise
	}
}
