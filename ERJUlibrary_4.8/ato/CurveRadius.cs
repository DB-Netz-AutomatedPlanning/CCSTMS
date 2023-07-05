using System.Xml.Serialization;
using System.Collections.Generic;
namespace ato
{
	[XmlRoot(Namespace = "https://erju.org/ato", ElementName = "curveRadius")]
	public enum CurveRadius
	{
		cr_R_7000,
		cr_7000_4500,
		cr_4500_2800,
		cr_2800_2000,
		cr_2000_1500,
		cr_1500_1250,
		cr_1250_1075,
		cr_1075_925,
		cr_925_825,
		cr_825_725,
		cr_725_625,
		cr_625_525,
		cr_525_475,
		cr_475_425,
		cr_425_375,
		cr_375_325,
		cr_325_300,
		cr_300_275,
		cr_275_250,
		cr_250_225,
		cr_225_200,
		cr_200_175,
		cr_175_150,
		cr_150,
	}
}
