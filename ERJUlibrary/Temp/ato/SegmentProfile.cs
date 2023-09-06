using System;
using System.Runtime.InteropServices;
using System.Xml.Serialization;
namespace ato
{
	[XmlRoot(Namespace = "https://erju.org/ato", ElementName = "segmentProfile")]
	public class SegmentProfile
	{		
		[XmlAttribute]
		public uint nidSP;		
		[XmlAttribute]
		public uint length;		
		[XmlAttribute]
		public uint version;		
		[XmlAttribute]
		public uint nidC;		
		[XmlAttribute]
		public uint eoaOffset;		
		[XmlAttribute]
		public uint utcOffset;		
		[XmlAttribute]
		public uint startAltitude;		
		[XmlAttribute]
		public bool atotsContactInfoDir;		
		public AtoTSContactInfo? atotsContactInfo;		
		public StaticSpeedProfileStart? staticSpeedProfileStart;		
		[XmlArrayItem("staticSpeedProfileChange", Namespace = "https://erju.org/ato")]
		public List<StaticSpeedProfileChange>? staticSpeedProfileChanges;		
		public SpecificStaticSpeedProfileStart? specificStaticSpeedProfileStart;		
		[XmlArrayItem("specificStaticSpeedProfileChange", Namespace = "https://erju.org/ato")]
		public List<SpecificStaticSpeedProfileChange>? specificStaticSpeedProfileChanges;		
		public GradientStart? gradientStart;		
		[XmlArrayItem("gradientChange", Namespace = "https://erju.org/ato")]
		public List<GradientChange>? gradientChanges;		
		public CurveStart? curveStart;		
		[XmlArrayItem("curveChange", Namespace = "https://erju.org/ato")]
		public List<CurveChange>? curveChanges;		
		public VoltageStart? voltageStart;		
		[XmlArrayItem("voltageChange", Namespace = "https://erju.org/ato")]
		public List<VoltageChange>? voltageChanges;		
		public CurrentStart? currentStart;		
		[XmlArrayItem("currentChange", Namespace = "https://erju.org/ato")]
		public List<CurrentChange>? currentChanges;		
		[XmlArrayItem("baliseGroup", Namespace = "https://erju.org/ato")]
		public List<BaliseGroup>? baliseGroups;		
		public TimingPoint? timingPoints;		
		[XmlArrayItem("segmentSection", Namespace = "https://erju.org/ato")]
		public List<SegmentSection>? platformAreas;		
		[XmlArrayItem("tunnel", Namespace = "https://erju.org/ato")]
		public List<Tunnel>? tunnels;		
		[XmlArrayItem("axleLoadSpeedProfile", Namespace = "https://erju.org/ato")]
		public List<AxleLoadSpeedProfile>? axleLoadSpeedProfiles;		
		[XmlArrayItem("unprotectedLX", Namespace = "https://erju.org/ato")]
		public List<UnprotectedLX>? unprotectedLXs;		
		[XmlArrayItem("permittedBrakingDistance", Namespace = "https://erju.org/ato")]
		public List<PermittedBrakingDistance>? permittedBrakingDistances;		
		[XmlArrayItem("segmentSection", Namespace = "https://erju.org/ato")]
		public List<SegmentSection>? switchOffEddyCurrentBrakeServiceBrakes;		
		[XmlArrayItem("segmentSection", Namespace = "https://erju.org/ato")]
		public List<SegmentSection>? switchOffEddyCurrentBrakeEmergencyBrakes;		
		[XmlArrayItem("segmentSection", Namespace = "https://erju.org/ato")]
		public List<SegmentSection>? switchOffRegenerativeBrakes;		
		[XmlArrayItem("segmentSection", Namespace = "https://erju.org/ato")]
		public List<SegmentSection>? switchOffMagneticShoeBrakes;		
		[XmlArrayItem("segmentSection", Namespace = "https://erju.org/ato")]
		public List<SegmentSection>? dynamicBrakeForceInhibitions;		
		[XmlArrayItem("limitedDynamicBrakeForce", Namespace = "https://erju.org/ato")]
		public List<LimitedDynamicBrakeForce>? limitedDynamicBrakeForces;
	}
}