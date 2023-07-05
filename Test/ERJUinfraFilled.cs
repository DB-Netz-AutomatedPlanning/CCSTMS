using System.Xml.Schema;
using System.Xml;
using System.Xml.Serialization;
using infra;
using System.Security.Cryptography.X509Certificates;
using infra;

namespace Test
{
    
    public class ERJUInfraFilled
    {
        string validationOutput = "";
        // Create a StringWriter to hold the serialized XML
        StringWriter writer = new StringWriter();
        // Create an instance of XmlSerializerNamespaces to define namespaces
        XmlSerializerNamespaces namespaces = new XmlSerializerNamespaces();
       

        private void validate(string xml)
        {
            // Create an instance of XmlReaderSettings
            var settings = new XmlReaderSettings();

            // Enable XML schema validation
            settings.ValidationType = ValidationType.Schema;



            // Set the schema to validate against
            settings.Schemas.Add(null, "infra.xsd");
            // Set the schema to validate against
            settings.Schemas.Add(null, "eng.xsd");
            // Set the schema to validate against
            settings.Schemas.Add(null, "ato.xsd");
            // Set the schema to validate against
            settings.Schemas.Add(null, "tp.xsd");

            // Attach the validation event handler
            settings.ValidationEventHandler += ValidationCallback;


            // Create an instance of XmlReader with the XML file and settings
            using (var reader = XmlReader.Create(new StringReader(xml), settings))
            {
                validationOutput = "";
                try
                {
                    // Read through the XML document to trigger validation
                    while (reader.Read()) { }
                }
                catch (XmlException ex)
                {
                    validationOutput += ex.Message;
                }
            }
        }

        private void ValidationCallback(object sender, ValidationEventArgs e)
        {
            
            if (e.Severity == XmlSeverityType.Warning)
            {
                validationOutput +=  e.Message;
            }
            else if (e.Severity == XmlSeverityType.Error)
            {
                validationOutput += e.Message;
            }
        }



        [Fact]
        public void TrackEdge()
        {
            namespaces.Add("infra", "https://erju.org/infra");

            TrackEdge trackEdge = new TrackEdge();

            trackEdge.Id = "HelloWorld";
            trackEdge.Name = "HelloWorld";
            trackEdge.length = 4294967295;
            var serializer = new XmlSerializer(typeof(TrackEdge));

            serializer.Serialize(writer, trackEdge, namespaces);

            // Get the serialized XML as a string
            string xml = writer.ToString();

            validate(xml);

            Assert.Equal("", validationOutput);
        }
        [Fact]
        public void TrackEdgeLink()
        {
            namespaces.Add("infra", "https://erju.org/infra");

            TrackEdgeLink trackEdgeLink = new TrackEdgeLink();

            trackEdgeLink.Id = "HelloWorld";
            trackEdgeLink.TrackEdgeA = "";
            trackEdgeLink.TrackEdgeB = "";
            trackEdgeLink.startOnA = true;
            trackEdgeLink.startOnB = true;
            var serializer = new XmlSerializer(typeof(TrackEdgeLink));

            serializer.Serialize(writer, trackEdgeLink, namespaces);

            // Get the serialized XML as a string
            string xml = writer.ToString();

            validate(xml);

            Assert.Equal("", validationOutput);
        }
        [Fact]
        public void TopoArea()
        {
            namespaces.Add("infra", "https://erju.org/infra");

            TopoArea topoArea = new TopoArea();

            topoArea.Id = "HelloWorld";
            topoArea.trackEdges = new();
            topoArea.trackEdgeLinks = new();
            var serializer = new XmlSerializer(typeof(TopoArea));

            serializer.Serialize(writer, topoArea, namespaces);

            // Get the serialized XML as a string
            string xml = writer.ToString();

            validate(xml);

            Assert.Equal("", validationOutput);
        }
        [Fact]
        public void TrackEdgePoint()
        {
            namespaces.Add("infra", "https://erju.org/infra");

            TrackEdgePoint trackEdgePoint = new TrackEdgePoint();

            trackEdgePoint.TrackEdge = "";
            trackEdgePoint.p = 4294967295;
            trackEdgePoint.lateralOffset = -2147483647;
            var serializer = new XmlSerializer(typeof(TrackEdgePoint));

            serializer.Serialize(writer, trackEdgePoint, namespaces);

            // Get the serialized XML as a string
            string xml = writer.ToString();

            validate(xml);

            Assert.Equal("", validationOutput);
        }
        [Fact]
        public void DirTrackEdgePoint()
        {
            namespaces.Add("infra", "https://erju.org/infra");

            DirTrackEdgePoint dirTrackEdgePoint = new DirTrackEdgePoint();

            dirTrackEdgePoint.trackEdgePoint = new();
            dirTrackEdgePoint.direction = new();
            var serializer = new XmlSerializer(typeof(DirTrackEdgePoint));

            serializer.Serialize(writer, dirTrackEdgePoint, namespaces);

            // Get the serialized XML as a string
            string xml = writer.ToString();

            validate(xml);

            Assert.Equal("", validationOutput);
        }
        [Fact]
        public void TrackEdgeSection()
        {
            namespaces.Add("infra", "https://erju.org/infra");

            TrackEdgeSection trackEdgeSection = new TrackEdgeSection();

            trackEdgeSection.TrackEdge = "";
            trackEdgeSection.skipFromStart = 4294967295;
            trackEdgeSection.skipFromEnd = 4294967295;
            var serializer = new XmlSerializer(typeof(TrackEdgeSection));

            serializer.Serialize(writer, trackEdgeSection, namespaces);

            // Get the serialized XML as a string
            string xml = writer.ToString();

            validate(xml);

            Assert.Equal("", validationOutput);
        }
        [Fact]
        public void DirTrackEdge()
        {
            namespaces.Add("infra", "https://erju.org/infra");

            DirTrackEdge dirTrackEdge = new DirTrackEdge();

            dirTrackEdge.TrackEdge = "";
            dirTrackEdge.dirStartToEnd = true;
            var serializer = new XmlSerializer(typeof(DirTrackEdge));

            serializer.Serialize(writer, dirTrackEdge, namespaces);

            // Get the serialized XML as a string
            string xml = writer.ToString();

            validate(xml);

            Assert.Equal("", validationOutput);
        }
        [Fact]
        public void LinkedPath()
        {
            namespaces.Add("infra", "https://erju.org/infra");

            LinkedPath linkedPath = new LinkedPath();

            linkedPath.dirTrackEdges = new();
            linkedPath.skipFromStart = 4294967295;
            linkedPath.skipFromEnd = 4294967295;
            var serializer = new XmlSerializer(typeof(LinkedPath));

            serializer.Serialize(writer, linkedPath, namespaces);

            // Get the serialized XML as a string
            string xml = writer.ToString();

            validate(xml);

            Assert.Equal("", validationOutput);
        }
        [Fact]
        public void GeometryArea()
        {
            namespaces.Add("infra", "https://erju.org/infra");

            GeometryArea geometryArea = new GeometryArea();

            geometryArea.Id = "HelloWorld";
            geometryArea.alignment3d = true;
            geometryArea.trackEdgeGeometries = new();
            geometryArea.sampledTrackEdgeGeometries = new();
            var serializer = new XmlSerializer(typeof(GeometryArea));

            serializer.Serialize(writer, geometryArea, namespaces);

            // Get the serialized XML as a string
            string xml = writer.ToString();

            validate(xml);

            Assert.Equal("", validationOutput);
        }
        [Fact]
        public void TrackEdgeGeometry()
        {
            namespaces.Add("infra", "https://erju.org/infra");

            TrackEdgeGeometry trackEdgeGeometry = new TrackEdgeGeometry();

            trackEdgeGeometry.TrackEdge = "";
            trackEdgeGeometry.horizontalAlignment = new();
            trackEdgeGeometry.verticalAlignment = new();
            trackEdgeGeometry.cantSamples = new();
            var serializer = new XmlSerializer(typeof(TrackEdgeGeometry));

            serializer.Serialize(writer, trackEdgeGeometry, namespaces);

            // Get the serialized XML as a string
            string xml = writer.ToString();

            validate(xml);

            Assert.Equal("", validationOutput);
        }
        [Fact]
        public void HorizontalSegment()
        {
            namespaces.Add("infra", "https://erju.org/infra");

            HorizontalSegment horizontalSegment = new HorizontalSegment();

            horizontalSegment.line = new();
            horizontalSegment.arc = new();
            horizontalSegment.transition = new();
            var serializer = new XmlSerializer(typeof(HorizontalSegment));

            serializer.Serialize(writer, horizontalSegment, namespaces);

            // Get the serialized XML as a string
            string xml = writer.ToString();

            validate(xml);

            Assert.Equal("", validationOutput);
        }
        [Fact]
        public void HorizontalLine()
        {
            namespaces.Add("infra", "https://erju.org/infra");

            HorizontalLine horizontalLine = new HorizontalLine();

            horizontalLine.p = 4294967295;
            horizontalLine.azimuth = -2147483647;
            var serializer = new XmlSerializer(typeof(HorizontalLine));

            serializer.Serialize(writer, horizontalLine, namespaces);

            // Get the serialized XML as a string
            string xml = writer.ToString();

            validate(xml);

            Assert.Equal("", validationOutput);
        }
        [Fact]
        public void HorizontalArc()
        {
            namespaces.Add("infra", "https://erju.org/infra");

            HorizontalArc horizontalArc = new HorizontalArc();

            horizontalArc.p = 4294967295;
            horizontalArc.azimuth = 4294967295;
            horizontalArc.radius = -2147483647;
            var serializer = new XmlSerializer(typeof(HorizontalArc));

            serializer.Serialize(writer, horizontalArc, namespaces);

            // Get the serialized XML as a string
            string xml = writer.ToString();

            validate(xml);

            Assert.Equal("", validationOutput);
        }
        [Fact]
        public void HorizontalTransition()
        {
            namespaces.Add("infra", "https://erju.org/infra");

            HorizontalTransition horizontalTransition = new HorizontalTransition();

            horizontalTransition.p = 4294967295;
            horizontalTransition.azimuth = 4294967295;
            horizontalTransition.radius = -2147483647;
            horizontalTransition.type = new();
            var serializer = new XmlSerializer(typeof(HorizontalTransition));

            serializer.Serialize(writer, horizontalTransition, namespaces);

            // Get the serialized XML as a string
            string xml = writer.ToString();

            validate(xml);

            Assert.Equal("", validationOutput);
        }
        [Fact]
        public void VerticalSegment()
        {
            namespaces.Add("infra", "https://erju.org/infra");

            VerticalSegment verticalSegment = new VerticalSegment();

            verticalSegment.line = new();
            verticalSegment.arc = new();
            var serializer = new XmlSerializer(typeof(VerticalSegment));

            serializer.Serialize(writer, verticalSegment, namespaces);

            // Get the serialized XML as a string
            string xml = writer.ToString();

            validate(xml);

            Assert.Equal("", validationOutput);
        }
        [Fact]
        public void VerticalLine()
        {
            namespaces.Add("infra", "https://erju.org/infra");

            VerticalLine verticalLine = new VerticalLine();

            verticalLine.p = 4294967295;
            verticalLine.slope = -2147483647;
            var serializer = new XmlSerializer(typeof(VerticalLine));

            serializer.Serialize(writer, verticalLine, namespaces);

            // Get the serialized XML as a string
            string xml = writer.ToString();

            validate(xml);

            Assert.Equal("", validationOutput);
        }
        [Fact]
        public void VerticalArc()
        {
            namespaces.Add("infra", "https://erju.org/infra");

            VerticalArc verticalArc = new VerticalArc();

            verticalArc.p = 4294967295;
            verticalArc.slope = -2147483647;
            verticalArc.radius = -2147483647;
            var serializer = new XmlSerializer(typeof(VerticalArc));

            serializer.Serialize(writer, verticalArc, namespaces);

            // Get the serialized XML as a string
            string xml = writer.ToString();

            validate(xml);

            Assert.Equal("", validationOutput);
        }
        [Fact]
        public void CantSamplePoint()
        {
            namespaces.Add("infra", "https://erju.org/infra");

            CantSamplePoint cantSamplePoint = new CantSamplePoint();

            cantSamplePoint.p = 4294967295;
            cantSamplePoint.cant = -2147483647;
            cantSamplePoint.c = -2147483647;
            var serializer = new XmlSerializer(typeof(CantSamplePoint));

            serializer.Serialize(writer, cantSamplePoint, namespaces);

            // Get the serialized XML as a string
            string xml = writer.ToString();

            validate(xml);

            Assert.Equal("", validationOutput);
        }
        [Fact]
        public void SampledGeometryArea()
        {
            namespaces.Add("infra", "https://erju.org/infra");

            SampledGeometryArea sampledGeometryArea = new SampledGeometryArea();

            sampledGeometryArea.Id = "HelloWorld";
            sampledGeometryArea.sampledTrackEdgeGeometries = new();
            var serializer = new XmlSerializer(typeof(SampledGeometryArea));

            serializer.Serialize(writer, sampledGeometryArea, namespaces);

            // Get the serialized XML as a string
            string xml = writer.ToString();

            validate(xml);

            Assert.Equal("", validationOutput);
        }
        [Fact]
        public void SampledTrackEdgeGeometry()
        {
            namespaces.Add("infra", "https://erju.org/infra");

            SampledTrackEdgeGeometry sampledTrackEdgeGeometry = new SampledTrackEdgeGeometry();

            sampledTrackEdgeGeometry.TrackEdge = "";
            sampledTrackEdgeGeometry.slopes = new();
            sampledTrackEdgeGeometry.curves = new();
            sampledTrackEdgeGeometry.cants = new();
            var serializer = new XmlSerializer(typeof(SampledTrackEdgeGeometry));

            serializer.Serialize(writer, sampledTrackEdgeGeometry, namespaces);

            // Get the serialized XML as a string
            string xml = writer.ToString();

            validate(xml);

            Assert.Equal("", validationOutput);
        }
        [Fact]
        public void SlopeSamplePoint()
        {
            namespaces.Add("infra", "https://erju.org/infra");

            SlopeSamplePoint slopeSamplePoint = new SlopeSamplePoint();

            slopeSamplePoint.p = 4294967295;
            slopeSamplePoint.s = -2147483647;
            var serializer = new XmlSerializer(typeof(SlopeSamplePoint));

            serializer.Serialize(writer, slopeSamplePoint, namespaces);

            // Get the serialized XML as a string
            string xml = writer.ToString();

            validate(xml);

            Assert.Equal("", validationOutput);
        }
        [Fact]
        public void CurveSamplePoint()
        {
            namespaces.Add("infra", "https://erju.org/infra");

            CurveSamplePoint curveSamplePoint = new CurveSamplePoint();

            curveSamplePoint.p = 4294967295;
            curveSamplePoint.r = -2147483647;
            var serializer = new XmlSerializer(typeof(CurveSamplePoint));

            serializer.Serialize(writer, curveSamplePoint, namespaces);

            // Get the serialized XML as a string
            string xml = writer.ToString();

            validate(xml);

            Assert.Equal("", validationOutput);
        }
        [Fact]
        public void SimplePoint()
        {
            namespaces.Add("infra", "https://erju.org/infra");

            SimplePoint simplePoint = new SimplePoint();

            simplePoint.Id = "HelloWorld";
            simplePoint.Name = "HelloWorld";
            simplePoint.reversalTime = 4294967295;
            simplePoint.trackEdgeLinks = new() { new()};
            var serializer = new XmlSerializer(typeof(SimplePoint));

            serializer.Serialize(writer, simplePoint, namespaces);

            // Get the serialized XML as a string
            string xml = writer.ToString();

            validate(xml);

            Assert.Equal("", validationOutput);
        }
        [Fact]
        public void SlipCrossing()
        {
            namespaces.Add("infra", "https://erju.org/infra");

            SlipCrossing slipCrossing = new SlipCrossing();

            slipCrossing.Id = "HelloWorld";
            slipCrossing.Name = "HelloWorld";
            slipCrossing.simplePoints = new() { new()};
            var serializer = new XmlSerializer(typeof(SlipCrossing));

            serializer.Serialize(writer, slipCrossing, namespaces);

            // Get the serialized XML as a string
            string xml = writer.ToString();

            validate(xml);

            Assert.Equal("", validationOutput);
        }
        [Fact]
        public void Derailer()
        {
            namespaces.Add("infra", "https://erju.org/infra");

            Derailer derailer = new Derailer();

            derailer.Id = "HelloWorld";
            derailer.Name = "HelloWorld";
            derailer.trackEdgePoint = new();
            derailer.reversalTime = 4294967295;
            derailer.derailToRight = true;
            derailer.dirStartToEnd = true;
            var serializer = new XmlSerializer(typeof(Derailer));

            serializer.Serialize(writer, derailer, namespaces);

            // Get the serialized XML as a string
            string xml = writer.ToString();

            validate(xml);

            Assert.Equal("", validationOutput);
        }
        [Fact]
        public void Crossing()
        {
            namespaces.Add("infra", "https://erju.org/infra");

            Crossing crossing = new Crossing();

            crossing.Id = "HelloWorld";
            crossing.Name = "HelloWorld";
            crossing.trackEdgePoints = new();
            var serializer = new XmlSerializer(typeof(Crossing));

            serializer.Serialize(writer, crossing, namespaces);

            // Get the serialized XML as a string
            string xml = writer.ToString();

            validate(xml);

            Assert.Equal("", validationOutput);
        }
        [Fact]
        public void BaliseGroup()
        {
            namespaces.Add("infra", "https://erju.org/infra");

            BaliseGroup baliseGroup = new BaliseGroup();

            baliseGroup.Id = "HelloWorld";
            baliseGroup.nidBG = 4294967295;
            baliseGroup.nidC = 4294967295;
            baliseGroup.balises = new();
            baliseGroup.bgFunction = new();
            baliseGroup.locationAccuracy = 4294967295;
            var serializer = new XmlSerializer(typeof(BaliseGroup));

            serializer.Serialize(writer, baliseGroup, namespaces);

            // Get the serialized XML as a string
            string xml = writer.ToString();

            validate(xml);

            Assert.Equal("", validationOutput);
        }
        [Fact]
        public void Balise()
        {
            namespaces.Add("infra", "https://erju.org/infra");

            Balise balise = new Balise();

            balise.Id = "HelloWorld";
            balise.trackEdgePoint = new();
            balise.positionInGroup = 4294967295;
            var serializer = new XmlSerializer(typeof(Balise));

            serializer.Serialize(writer, balise, namespaces);

            // Get the serialized XML as a string
            string xml = writer.ToString();

            validate(xml);

            Assert.Equal("", validationOutput);
        }
        [Fact]
        public void PropertiesArea()
        {
            namespaces.Add("infra", "https://erju.org/infra");

            PropertiesArea propertiesArea = new PropertiesArea();

            propertiesArea.AreaId = "HelloWorld";
            propertiesArea.gauge = 4294967295;
            propertiesArea.loadingGaugeType = new();
            propertiesArea.trackEdgeGauges = new();
            propertiesArea.trackEdgeLoadingGauges = new();
            propertiesArea.trackConditions = new();
            propertiesArea.secondaryTracks = new() {new()};
            propertiesArea.shuntingTracks = new() { new() };
            var serializer = new XmlSerializer(typeof(PropertiesArea));

            serializer.Serialize(writer, propertiesArea, namespaces);

            // Get the serialized XML as a string
            string xml = writer.ToString();

            validate(xml);

            Assert.Equal("", validationOutput);
        }
        [Fact]
        public void TrackEdgeGauge()
        {
            namespaces.Add("infra", "https://erju.org/infra");

            TrackEdgeGauge trackEdgeGauge = new TrackEdgeGauge();

            trackEdgeGauge.trackSections = new();
            trackEdgeGauge.gauge = 4294967295;
            var serializer = new XmlSerializer(typeof(TrackEdgeGauge));

            serializer.Serialize(writer, trackEdgeGauge, namespaces);

            // Get the serialized XML as a string
            string xml = writer.ToString();

            validate(xml);

            Assert.Equal("", validationOutput);
        }
        [Fact]
        public void TrackEdgeLoadingGauge()
        {
            namespaces.Add("infra", "https://erju.org/infra");

            TrackEdgeLoadingGauge trackEdgeLoadingGauge = new TrackEdgeLoadingGauge();

            trackEdgeLoadingGauge.trackSections = new();
            trackEdgeLoadingGauge.loadingGaugeType = new();
            var serializer = new XmlSerializer(typeof(TrackEdgeLoadingGauge));

            serializer.Serialize(writer, trackEdgeLoadingGauge, namespaces);

            // Get the serialized XML as a string
            string xml = writer.ToString();

            validate(xml);

            Assert.Equal("", validationOutput);
        }
        [Fact]
        public void TrackCondition()
        {
            namespaces.Add("infra", "https://erju.org/infra");

            TrackCondition trackCondition = new TrackCondition();

            trackCondition.trackSections = new();
            trackCondition.type = new();
            var serializer = new XmlSerializer(typeof(TrackCondition));

            serializer.Serialize(writer, trackCondition, namespaces);

            // Get the serialized XML as a string
            string xml = writer.ToString();

            validate(xml);

            Assert.Equal("", validationOutput);
        }
        [Fact]
        public void CurrentLimitation()
        {
            namespaces.Add("infra", "https://erju.org/infra");

            CurrentLimitation currentLimitation = new CurrentLimitation();

            currentLimitation.trackSections = new();
            currentLimitation.maxCurrent = 4294967295;
            var serializer = new XmlSerializer(typeof(CurrentLimitation));

            serializer.Serialize(writer, currentLimitation, namespaces);

            // Get the serialized XML as a string
            string xml = writer.ToString();

            validate(xml);

            Assert.Equal("", validationOutput);
        }
        [Fact]
        public void PermittedBrakingDistance()
        {
            namespaces.Add("infra", "https://erju.org/infra");

            PermittedBrakingDistance permittedBrakingDistance = new PermittedBrakingDistance();

            permittedBrakingDistance.trackSections = new();
            permittedBrakingDistance.pbdDist = 4294967295;
            permittedBrakingDistance.brakeType = BreakType.serviceBrake;
            permittedBrakingDistance.pbdGradient = -2147483647;
            var serializer = new XmlSerializer(typeof(PermittedBrakingDistance));

            serializer.Serialize(writer, permittedBrakingDistance, namespaces);

            // Get the serialized XML as a string
            string xml = writer.ToString();

            validate(xml);

            Assert.Equal("", validationOutput);
        }
        [Fact]
        public void TrackEdgeSpeedProfile()
        {
            namespaces.Add("infra", "https://erju.org/infra");

            TrackEdgeSpeedProfile trackEdgeSpeedProfile = new TrackEdgeSpeedProfile();

            trackEdgeSpeedProfile.Id = "HelloWorld";
            trackEdgeSpeedProfile.TrackEdge = "";
            trackEdgeSpeedProfile.staticSpeedProfile = new();
            trackEdgeSpeedProfile.axleLoadSpeedProfiles = new();
            trackEdgeSpeedProfile.direction = new();
            var serializer = new XmlSerializer(typeof(TrackEdgeSpeedProfile));

            serializer.Serialize(writer, trackEdgeSpeedProfile, namespaces);

            // Get the serialized XML as a string
            string xml = writer.ToString();

            validate(xml);

            Assert.Equal("", validationOutput);
        }
        [Fact]
        public void StaticSpeedLimit()
        {
            namespaces.Add("infra", "https://erju.org/infra");

            StaticSpeedLimit staticSpeedLimit = new StaticSpeedLimit();

            staticSpeedLimit.p = 4294967295;
            staticSpeedLimit.speed = 4294967295;
            staticSpeedLimit.specificStaticSpeedLimits = new();
            var serializer = new XmlSerializer(typeof(StaticSpeedLimit));

            serializer.Serialize(writer, staticSpeedLimit, namespaces);

            // Get the serialized XML as a string
            string xml = writer.ToString();

            validate(xml);

            Assert.Equal("", validationOutput);
        }
        [Fact]
        public void SpecificStaticSpeedLimit()
        {
            namespaces.Add("infra", "https://erju.org/infra");

            SpecificStaticSpeedLimit specificStaticSpeedLimit = new SpecificStaticSpeedLimit();

            specificStaticSpeedLimit.speed = 4294967295;
            specificStaticSpeedLimit.specificLimitType = new();
            var serializer = new XmlSerializer(typeof(SpecificStaticSpeedLimit));

            serializer.Serialize(writer, specificStaticSpeedLimit, namespaces);

            // Get the serialized XML as a string
            string xml = writer.ToString();

            validate(xml);

            Assert.Equal("", validationOutput);
        }
        [Fact]
        public void SpeedLimitType()
        {
            namespaces.Add("infra", "https://erju.org/infra");

            SpeedLimitType speedLimitType = new SpeedLimitType();

            speedLimitType.otherCategory = new();
            speedLimitType.cantDeficiency = new();
            var serializer = new XmlSerializer(typeof(SpeedLimitType));

            serializer.Serialize(writer, speedLimitType, namespaces);

            // Get the serialized XML as a string
            string xml = writer.ToString();

            validate(xml);

            Assert.Equal("", validationOutput);
        }
        [Fact]
        public void AxleLoadSpeedProfile()
        {
            namespaces.Add("infra", "https://erju.org/infra");

            AxleLoadSpeedProfile axleLoadSpeedProfile = new AxleLoadSpeedProfile();

            axleLoadSpeedProfile.startP = 4294967295;
            axleLoadSpeedProfile.endP = 4294967295;
            axleLoadSpeedProfile.speed = 4294967295;
            axleLoadSpeedProfile.axleLoadCategory = new();
            var serializer = new XmlSerializer(typeof(AxleLoadSpeedProfile));

            serializer.Serialize(writer, axleLoadSpeedProfile, namespaces);

            // Get the serialized XML as a string
            string xml = writer.ToString();

            validate(xml);

            Assert.Equal("", validationOutput);
        }
        [Fact]
        public void MileageMarker()
        {
            namespaces.Add("infra", "https://erju.org/infra");

            MileageMarker mileageMarker = new MileageMarker();

            mileageMarker.p = 4294967295;
            mileageMarker.v = 4294967295;
            var serializer = new XmlSerializer(typeof(MileageMarker));

            serializer.Serialize(writer, mileageMarker, namespaces);

            // Get the serialized XML as a string
            string xml = writer.ToString();

            validate(xml);

            Assert.Equal("", validationOutput);
        }
        [Fact]
        public void TrackEdgeMileageLineSegment()
        {
            namespaces.Add("infra", "https://erju.org/infra");

            TrackEdgeMileageLineSegment trackEdgeMileageLineSegment = new TrackEdgeMileageLineSegment();

            trackEdgeMileageLineSegment.TrackEdge = "";
            trackEdgeMileageLineSegment.points = new();
            var serializer = new XmlSerializer(typeof(TrackEdgeMileageLineSegment));

            serializer.Serialize(writer, trackEdgeMileageLineSegment, namespaces);

            // Get the serialized XML as a string
            string xml = writer.ToString();

            validate(xml);

            Assert.Equal("", validationOutput);
        }
        [Fact]
        public void MileageLine()
        {
            namespaces.Add("infra", "https://erju.org/infra");

            MileageLine mileageLine = new MileageLine();

            mileageLine.Id = "HelloWorld";
            mileageLine.trackEdges = new() { points=new()};
            var serializer = new XmlSerializer(typeof(MileageLine));

            serializer.Serialize(writer, mileageLine, namespaces);

            // Get the serialized XML as a string
            string xml = writer.ToString();

            validate(xml);

            Assert.Equal("", validationOutput);
        }
        [Fact]
        public void MileageArea()
        {
            namespaces.Add("infra", "https://erju.org/infra");

            MileageArea mileageArea = new MileageArea();

            mileageArea.AreaId = "HelloWorld";
            mileageArea.mileageLines = new() { trackEdges=new() {points=new() } };
            var serializer = new XmlSerializer(typeof(MileageArea));

            serializer.Serialize(writer, mileageArea, namespaces);

            // Get the serialized XML as a string
            string xml = writer.ToString();

            validate(xml);

            Assert.Equal("", validationOutput);
        }
        [Fact]
        public void MapArea()
        {
            namespaces.Add("infra", "https://erju.org/infra");

            MapArea mapArea = new MapArea();

            mapArea.Id = "HelloWorld";
            mapArea.Name = "HelloWorld";
            mapArea.AreaId = "HelloWorld";
            mapArea.epsg = 4294967295;
            mapArea.trackEdges = new();
            mapArea.funcElements = new();
            var serializer = new XmlSerializer(typeof(MapArea));

            serializer.Serialize(writer, mapArea, namespaces);

            // Get the serialized XML as a string
            string xml = writer.ToString();

            validate(xml);

            Assert.Equal("", validationOutput);
        }
        [Fact]
        public void TrackEdgeProjection()
        {
            namespaces.Add("infra", "https://erju.org/infra");

            TrackEdgeProjection trackEdgeProjection = new TrackEdgeProjection();

            trackEdgeProjection.TrackEdgeId = "HelloWorld";
            trackEdgeProjection.coordinates = new();
            var serializer = new XmlSerializer(typeof(TrackEdgeProjection));

            serializer.Serialize(writer, trackEdgeProjection, namespaces);

            // Get the serialized XML as a string
            string xml = writer.ToString();

            validate(xml);

            Assert.Equal("", validationOutput);
        }
        [Fact]
        public void TrackEdgeCoordinate()
        {
            namespaces.Add("infra", "https://erju.org/infra");

            TrackEdgeCoordinate trackEdgeCoordinate = new TrackEdgeCoordinate();

            trackEdgeCoordinate.p = 4294967295;
            trackEdgeCoordinate.x = 100.0;
            trackEdgeCoordinate.y = 100.0;
            trackEdgeCoordinate.z = 100.0;
            var serializer = new XmlSerializer(typeof(TrackEdgeCoordinate));

            serializer.Serialize(writer, trackEdgeCoordinate, namespaces);

            // Get the serialized XML as a string
            string xml = writer.ToString();

            validate(xml);

            Assert.Equal("", validationOutput);
        }
        [Fact]
        public void FuncElementProjection()
        {
            namespaces.Add("infra", "https://erju.org/infra");

            FuncElementProjection funcElementProjection = new FuncElementProjection();

            funcElementProjection.elementRef = new();
            funcElementProjection.x = 100.0;
            funcElementProjection.y = 100.0;
            funcElementProjection.z = 100.0;
            var serializer = new XmlSerializer(typeof(FuncElementProjection));

            serializer.Serialize(writer, funcElementProjection, namespaces);

            // Get the serialized XML as a string
            string xml = writer.ToString();

            validate(xml);

            Assert.Equal("", validationOutput);
        }
        [Fact]
        public void FuncElementRef()
        {
            namespaces.Add("infra", "https://erju.org/infra");

            FuncElementRef funcElementRef = new FuncElementRef();

            funcElementRef.SimplePoint = "";
            funcElementRef.EtcsMarker = "";
            funcElementRef.StopLocation = "";
            funcElementRef.TimingPoint = "";
            funcElementRef.OperationalPoint = "";
            funcElementRef.Balise = "";
            var serializer = new XmlSerializer(typeof(FuncElementRef));

            serializer.Serialize(writer, funcElementRef, namespaces);

            // Get the serialized XML as a string
            string xml = writer.ToString();

            validate(xml);

            Assert.Equal("", validationOutput);
        }
        [Fact]
        public void ETCSMarker()
        {
            namespaces.Add("infra", "https://erju.org/infra");

            ETCSMarker eTCSMarker = new ETCSMarker();

            eTCSMarker.Id = "HelloWorld";
            eTCSMarker.Name = "HelloWorld";
            eTCSMarker.dirTrackEdgePoint = new() { trackEdgePoint=new()};
            eTCSMarker.markerFunctionStop = true;
            var serializer = new XmlSerializer(typeof(ETCSMarker));

            serializer.Serialize(writer, eTCSMarker, namespaces);

            // Get the serialized XML as a string
            string xml = writer.ToString();

            validate(xml);

            Assert.Equal("", validationOutput);
        }
        [Fact]
        public void StopLocation()
        {
            namespaces.Add("infra", "https://erju.org/infra");

            StopLocation stopLocation = new StopLocation();

            stopLocation.id = 12223;
            stopLocation.Name = "HelloWorld";
            stopLocation.trackEdgePoint = new();
            stopLocation.stopTrainLimit = new() { trainLimitLength=new(),trainLimitAxles=new(),trainLimitWagons=new(),trainLimitSize=new()};
            var serializer = new XmlSerializer(typeof(StopLocation));

            serializer.Serialize(writer, stopLocation, namespaces);

            // Get the serialized XML as a string
            string xml = writer.ToString();

            validate(xml);

            Assert.Equal("", validationOutput);
        }
        [Fact]
        public void StopTrainLimitLength()
        {
            namespaces.Add("infra", "https://erju.org/infra");

            StopTrainLimitLength stopTrainLimitLength = new StopTrainLimitLength();

            stopTrainLimitLength.maxTrainLength = 4294967295;
            var serializer = new XmlSerializer(typeof(StopTrainLimitLength));

            serializer.Serialize(writer, stopTrainLimitLength, namespaces);

            // Get the serialized XML as a string
            string xml = writer.ToString();

            validate(xml);

            Assert.Equal("", validationOutput);
        }
        [Fact]
        public void StopTrainLimitAxles()
        {
            namespaces.Add("infra", "https://erju.org/infra");

            StopTrainLimitAxles stopTrainLimitAxles = new StopTrainLimitAxles();

            stopTrainLimitAxles.maxTrainLength = 4294967295;
            var serializer = new XmlSerializer(typeof(StopTrainLimitAxles));

            serializer.Serialize(writer, stopTrainLimitAxles, namespaces);

            // Get the serialized XML as a string
            string xml = writer.ToString();

            validate(xml);

            Assert.Equal("", validationOutput);
        }
        [Fact]
        public void StopTrainLimitWagons()
        {
            namespaces.Add("infra", "https://erju.org/infra");

            StopTrainLimitWagons stopTrainLimitWagons = new StopTrainLimitWagons();

            stopTrainLimitWagons.maxWagonNumber = 4294967295;
            var serializer = new XmlSerializer(typeof(StopTrainLimitWagons));

            serializer.Serialize(writer, stopTrainLimitWagons, namespaces);

            // Get the serialized XML as a string
            string xml = writer.ToString();

            validate(xml);

            Assert.Equal("", validationOutput);
        }
        [Fact]
        public void StopTrainLimitSize()
        {
            namespaces.Add("infra", "https://erju.org/infra");

            StopTrainLimitSize stopTrainLimitSize = new StopTrainLimitSize();

            stopTrainLimitSize.trainSize = new();
            var serializer = new XmlSerializer(typeof(StopTrainLimitSize));

            serializer.Serialize(writer, stopTrainLimitSize, namespaces);

            // Get the serialized XML as a string
            string xml = writer.ToString();

            validate(xml);

            Assert.Equal("", validationOutput);
        }
        [Fact]
        public void StopTrainLimit()
        {
            namespaces.Add("infra", "https://erju.org/infra");

            StopTrainLimit stopTrainLimit = new StopTrainLimit();

            stopTrainLimit.trainLimitLength = new();
            stopTrainLimit.trainLimitAxles = new();
            stopTrainLimit.trainLimitWagons = new();
            stopTrainLimit.trainLimitSize = new();
            var serializer = new XmlSerializer(typeof(StopTrainLimit));

            serializer.Serialize(writer, stopTrainLimit, namespaces);

            // Get the serialized XML as a string
            string xml = writer.ToString();

            validate(xml);

            Assert.Equal("", validationOutput);
        }
        [Fact]
        public void MpTargetMarker()
        {
            namespaces.Add("infra", "https://erju.org/infra");

            MpTargetMarker mpTargetMarker = new MpTargetMarker();

            mpTargetMarker.Id = "HelloWorld";
            mpTargetMarker.type = new();
            mpTargetMarker.trackEdgePoint = new();
            var serializer = new XmlSerializer(typeof(MpTargetMarker));

            serializer.Serialize(writer, mpTargetMarker, namespaces);

            // Get the serialized XML as a string
            string xml = writer.ToString();

            validate(xml);

            Assert.Equal("", validationOutput);
        }
        [Fact]
        public void PlatformEdge()
        {
            namespaces.Add("infra", "https://erju.org/infra");

            PlatformEdge platformEdge = new PlatformEdge();

            platformEdge.Id = "HelloWorld";
            platformEdge.Name = "HelloWorld";
            platformEdge.linearLocation = new();
            platformEdge.stopLocations = new() { new()};
            var serializer = new XmlSerializer(typeof(PlatformEdge));

            serializer.Serialize(writer, platformEdge, namespaces);

            // Get the serialized XML as a string
            string xml = writer.ToString();

            validate(xml);

            Assert.Equal("", validationOutput);
        }
        [Fact]
        public void Platform()
        {
            namespaces.Add("infra", "https://erju.org/infra");

            Platform platform = new Platform();

            platform.Id = "HelloWorld";
            platform.Name = "HelloWorld";
            platform.platformEdges = new();
            var serializer = new XmlSerializer(typeof(Platform));

            serializer.Serialize(writer, platform, namespaces);

            // Get the serialized XML as a string
            string xml = writer.ToString();

            validate(xml);

            Assert.Equal("", validationOutput);
        }
        [Fact]
        public void OperationalPoint()
        {
            namespaces.Add("infra", "https://erju.org/infra");

            OperationalPoint operationalPoint = new OperationalPoint();

            operationalPoint.Id = "HelloWorld";
            operationalPoint.Name = "HelloWorld";
            operationalPoint.timingPoints = new() { new()};
            operationalPoint.type = new();
            operationalPoint.platforms = new();
            var serializer = new XmlSerializer(typeof(OperationalPoint));

            serializer.Serialize(writer, operationalPoint, namespaces);

            // Get the serialized XML as a string
            string xml = writer.ToString();

            validate(xml);

            Assert.Equal("", validationOutput);
        }
        [Fact]
        public void TimingPoint()
        {
            namespaces.Add("infra", "https://erju.org/infra");

            TimingPoint timingPoint = new TimingPoint();

            timingPoint.Id = "HelloWorld";
            timingPoint.Name = "HelloWorld";
            timingPoint.trackEdgePoint = new();
            timingPoint.timingPointObject = new();
            timingPoint.direction = new();
            var serializer = new XmlSerializer(typeof(TimingPoint));

            serializer.Serialize(writer, timingPoint, namespaces);

            // Get the serialized XML as a string
            string xml = writer.ToString();

            validate(xml);

            Assert.Equal("", validationOutput);
        }
        [Fact]
        public void TimingPointObject()
        {
            namespaces.Add("infra", "https://erju.org/infra");

            TimingPointObject timingPointObject = new TimingPointObject();

            timingPointObject.EtcsMarkerBoard = "";
            timingPointObject.Platform = "";
            timingPointObject.StopLocation = "";
            var serializer = new XmlSerializer(typeof(TimingPointObject));

            serializer.Serialize(writer, timingPointObject, namespaces);

            // Get the serialized XML as a string
            string xml = writer.ToString();

            validate(xml);

            Assert.Equal("", validationOutput);
        }
        [Fact]
        public void Tunnel()
        {
            namespaces.Add("infra", "https://erju.org/infra");

            Tunnel tunnel = new Tunnel();

            tunnel.Id = "HelloWorld";
            tunnel.Name = "HelloWorld";
            tunnel.tunnelTubes = new();
            var serializer = new XmlSerializer(typeof(Tunnel));

            serializer.Serialize(writer, tunnel, namespaces);

            // Get the serialized XML as a string
            string xml = writer.ToString();

            validate(xml);

            Assert.Equal("", validationOutput);
        }
        [Fact]
        public void TunnelTube()
        {
            namespaces.Add("infra", "https://erju.org/infra");

            TunnelTube tunnelTube = new TunnelTube();

            tunnelTube.id = 4294967295;
            tunnelTube.startTunnelPortal = new() { trackEdgePoint=new()};
            tunnelTube.endTunnelPortal = new() { trackEdgePoint = new() }; ;
            tunnelTube.numberOfTracks = 4294967295;
            tunnelTube.trackSections = new();
            tunnelTube.tubeLength = 4294967295;
            tunnelTube.crossSection = 4294967295;
            var serializer = new XmlSerializer(typeof(TunnelTube));

            serializer.Serialize(writer, tunnelTube, namespaces);

            // Get the serialized XML as a string
            string xml = writer.ToString();

            validate(xml);

            Assert.Equal("", validationOutput);
        }
        [Fact]
        public void TunnelPortal()
        {
            namespaces.Add("infra", "https://erju.org/infra");

            TunnelPortal tunnelPortal = new TunnelPortal();

            tunnelPortal.Id = "HelloWorld";
            tunnelPortal.trackEdgePoint = new();
            var serializer = new XmlSerializer(typeof(TunnelPortal));

            serializer.Serialize(writer, tunnelPortal, namespaces);

            // Get the serialized XML as a string
            string xml = writer.ToString();

            validate(xml);

            Assert.Equal("", validationOutput);
        }
        [Fact]
        public void Bridge()
        {
            namespaces.Add("infra", "https://erju.org/infra");

            Bridge bridge = new Bridge();

            bridge.Id = "HelloWorld";
            bridge.Name = "HelloWorld";
            bridge.trackEdgeSections = new();
            var serializer = new XmlSerializer(typeof(Bridge));

            serializer.Serialize(writer, bridge, namespaces);

            // Get the serialized XML as a string
            string xml = writer.ToString();

            validate(xml);

            Assert.Equal("", validationOutput);
        }
        [Fact]
        public void Underpass()
        {
            namespaces.Add("infra", "https://erju.org/infra");

            Underpass underpass = new Underpass();

            underpass.Id = "HelloWorld";
            underpass.Name = "HelloWorld";
            underpass.trackEdgeSections = new();
            var serializer = new XmlSerializer(typeof(Underpass));

            serializer.Serialize(writer, underpass, namespaces);

            // Get the serialized XML as a string
            string xml = writer.ToString();

            validate(xml);

            Assert.Equal("", validationOutput);
        }
        [Fact]
        public void TvpSection()
        {
            namespaces.Add("infra", "https://erju.org/infra");

            TvpSection tvpSection = new TvpSection();

            tvpSection.Id = "HelloWorld";
            tvpSection.Name = "HelloWorld";
            tvpSection.trackSections = new();
            tvpSection.trainDetectors = new() { new()};
            var serializer = new XmlSerializer(typeof(TvpSection));

            serializer.Serialize(writer, tvpSection, namespaces);

            // Get the serialized XML as a string
            string xml = writer.ToString();

            validate(xml);

            Assert.Equal("", validationOutput);
        }
        [Fact]
        public void TrainDetector()
        {
            namespaces.Add("infra", "https://erju.org/infra");

            TrainDetector trainDetector = new TrainDetector();

            trainDetector.Id = "HelloWorld";
            trainDetector.Name = "HelloWorld";
            trainDetector.trackEdgePoint = new();
            trainDetector.type = new();
            var serializer = new XmlSerializer(typeof(TrainDetector));

            serializer.Serialize(writer, trainDetector, namespaces);

            // Get the serialized XML as a string
            string xml = writer.ToString();

            validate(xml);

            Assert.Equal("", validationOutput);
        }
        [Fact]
        public void LevelCrossing()
        {
            namespaces.Add("infra", "https://erju.org/infra");

            LevelCrossing levelCrossing = new LevelCrossing();

            levelCrossing.Id = "HelloWorld";
            levelCrossing.Name = "HelloWorld";
            levelCrossing.trackEdgeSections = new();
            var serializer = new XmlSerializer(typeof(LevelCrossing));

            serializer.Serialize(writer, levelCrossing, namespaces);

            // Get the serialized XML as a string
            string xml = writer.ToString();

            validate(xml);

            Assert.Equal("", validationOutput);
        }
        [Fact]
        public void NationalBorder()
        {
            namespaces.Add("infra", "https://erju.org/infra");

            NationalBorder nationalBorder = new NationalBorder();

            nationalBorder.Id = "HelloWorld";
            nationalBorder.trackEdgePoint = new();
            nationalBorder.FromCountryCode = "HelloWorld";
            nationalBorder.ToCountryCode = "HelloWorld";
            var serializer = new XmlSerializer(typeof(NationalBorder));

            serializer.Serialize(writer, nationalBorder, namespaces);

            // Get the serialized XML as a string
            string xml = writer.ToString();

            validate(xml);

            Assert.Equal("", validationOutput);
        }
        [Fact]
        public void BufferStop()
        {
            namespaces.Add("infra", "https://erju.org/infra");

            BufferStop bufferStop = new BufferStop();

            bufferStop.Id = "HelloWorld";
            bufferStop.trackEdgePoint = new();
            var serializer = new XmlSerializer(typeof(BufferStop));

            serializer.Serialize(writer, bufferStop, namespaces);

            // Get the serialized XML as a string
            string xml = writer.ToString();

            validate(xml);

            Assert.Equal("", validationOutput);
        }
        [Fact]
        public void FunctionalArea()
        {
            namespaces.Add("infra", "https://erju.org/infra");

            FunctionalArea functionalArea = new FunctionalArea();

            functionalArea.AreaId = "HelloWorld";
            functionalArea.opPoints = new();
            functionalArea.timingPoints = new();
            functionalArea.simplePoints = new();
            functionalArea.slipCrossings = new();
            functionalArea.derailers = new();
            functionalArea.crossings = new();
            functionalArea.baliseGroups = new();
            functionalArea.etcsMarkers = new();
            functionalArea.stopLocations = new();
            functionalArea.teSpeedProfiles = new();
            functionalArea.tunnels = new();
            functionalArea.bridges = new();
            functionalArea.underpasses = new();
            functionalArea.tvps = new();
            functionalArea.mpTargetMarkers = new();
            functionalArea.levelCrossings = new();
            functionalArea.nationalBorders = new();
            functionalArea.bufferStops = new();
            var serializer = new XmlSerializer(typeof(FunctionalArea));

            serializer.Serialize(writer, functionalArea, namespaces);

            // Get the serialized XML as a string
            string xml = writer.ToString();

            validate(xml);

            Assert.Equal("", validationOutput);
        }
        [Fact]
        public void Infrastructure()
        {
            namespaces.Add("infra", "https://erju.org/infra");

            Infrastructure infrastructure = new Infrastructure();

            infrastructure.topoAreas = new();
            infrastructure.geometryAreas = new();
            infrastructure.sampledGeometryAreas = new();
            infrastructure.functionalAreas = new();
            infrastructure.propertiesAreas = new();
            infrastructure.mileageAreas = new();
            infrastructure.mapAreas = new();
            var serializer = new XmlSerializer(typeof(Infrastructure));

            serializer.Serialize(writer, infrastructure, namespaces);

            // Get the serialized XML as a string
            string xml = writer.ToString();

            validate(xml);

            Assert.Equal("", validationOutput);
        }



    }
}