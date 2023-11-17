using System.Xml.Serialization;
using System.Collections.Generic;

namespace ato
{
	[XmlRoot(Namespace = "https://erju.org/ato", ElementName = "segmentProfile")]
	public class SegmentProfile
	{
		public ato.AtoTSContactInfo? atotsContactInfo {get;set;}
		public ato.StaticSpeedProfileStart? staticSpeedProfileStart {get;set;}
		[XmlArrayItem("staticSpeedProfileChange", Namespace = "https://erju.org/ato")]
		public List<ato.StaticSpeedProfileChange> staticSpeedProfileChanges;
		public ato.SpecificStaticSpeedProfileStart? specificStaticSpeedProfileStart {get;set;}
		[XmlArrayItem("specificStaticSpeedProfileChange", Namespace = "https://erju.org/ato")]
		public List<ato.SpecificStaticSpeedProfileChange> specificStaticSpeedProfileChanges;
		public ato.GradientStart? gradientStart {get;set;}
		[XmlArrayItem("gradientChange", Namespace = "https://erju.org/ato")]
		public List<ato.GradientChange> gradientChanges;
		public ato.CurveStart? curveStart {get;set;}
		[XmlArrayItem("curveChange", Namespace = "https://erju.org/ato")]
		public List<ato.CurveChange> curveChanges;
		public ato.VoltageStart? voltageStart {get;set;}
		[XmlArrayItem("voltageChange", Namespace = "https://erju.org/ato")]
		public List<ato.VoltageChange> voltageChanges;
		public ato.CurrentStart? currentStart {get;set;}
		[XmlArrayItem("currentChange", Namespace = "https://erju.org/ato")]
		public List<ato.CurrentChange> currentChanges;
		[XmlArrayItem("baliseGroup", Namespace = "https://erju.org/ato")]
		public List<ato.BaliseGroup> baliseGroups;
		[XmlArrayItem("timingPoint", Namespace = "https://erju.org/ato")]
		public List<ato.TimingPoint> timingPoints;
		[XmlArrayItem("platformArea", Namespace = "https://erju.org/ato")]
		public List<ato.SegmentSection> platformAreas;
		[XmlArrayItem("tunnel", Namespace = "https://erju.org/ato")]
		public List<ato.Tunnel> tunnels;
		[XmlArrayItem("axleLoadSpeedProfile", Namespace = "https://erju.org/ato")]
		public List<ato.AxleLoadSpeedProfile> axleLoadSpeedProfiles;
		[XmlArrayItem("unprotectedLX", Namespace = "https://erju.org/ato")]
		public List<ato.UnprotectedLX> unprotectedLXs;
		[XmlArrayItem("permittedBrakingDistance", Namespace = "https://erju.org/ato")]
		public List<ato.PermittedBrakingDistance> permittedBrakingDistances;
		[XmlArrayItem("switchOffEddyCurrentBrakeServiceBrake", Namespace = "https://erju.org/ato")]
		public List<ato.SegmentSection> switchOffEddyCurrentBrakeServiceBrakes;
		[XmlArrayItem("switchOffEddyCurrentBrakeEmergencyBrake", Namespace = "https://erju.org/ato")]
		public List<ato.SegmentSection> switchOffEddyCurrentBrakeEmergencyBrakes;
		[XmlArrayItem("switchOffRegenerativeBrake", Namespace = "https://erju.org/ato")]
		public List<ato.SegmentSection> switchOffRegenerativeBrakes;
		[XmlArrayItem("switchOffMagneticShoeBrake", Namespace = "https://erju.org/ato")]
		public List<ato.SegmentSection> switchOffMagneticShoeBrakes;
		[XmlArrayItem("dynamicBrakeForceInhibition", Namespace = "https://erju.org/ato")]
		public List<ato.SegmentSection> dynamicBrakeForceInhibitions;
		[XmlArrayItem("limitedDynamicBrakeForce", Namespace = "https://erju.org/ato")]
		public List<ato.LimitedDynamicBrakeForce> limitedDynamicBrakeForces;
		[XmlAttribute]
		public uint nidSP {get;set;}
		[XmlAttribute]
		public uint length {get;set;}
		[XmlAttribute]
		public uint version {get;set;}
		[XmlAttribute]
		public uint nidC {get;set;}
		[XmlAttribute]
		public uint eoaOffset {get;set;}
		[XmlAttribute]
		public uint utcOffset {get;set;}
		[XmlAttribute]
		public int startAltitude {get;set;}
		[XmlAttribute]
		public bool atotsContactInfoDir {get;set;}
	}
}