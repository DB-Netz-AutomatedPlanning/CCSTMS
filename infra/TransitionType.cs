using System.Xml.Serialization;
namespace infra
{
	[XmlRoot(Namespace = "https://erju.org/infra", ElementName = "transitionType")]
	public enum TransitionType
	{
		clothoidCurve,
		biquadraticParabola,
		blossCurve,
		cosineCurve,
		cubicParabola,
		sineCurve,
		wienerBogen,
	}
}