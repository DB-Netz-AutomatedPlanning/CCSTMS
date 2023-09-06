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
            // Set the schema to validate against
            settings.Schemas.Add(null, "ss026.xsd");
            // Set the schema to validate against
            settings.Schemas.Add(null, "tt.xsd");
            // Set the schema to validate against
            settings.Schemas.Add(null, "tt2.xsd");

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
            trackEdgeLink.TrackEdgeA = "HelloWorld";
            trackEdgeLink.TrackEdgeB = "HelloWorld";
            trackEdgeLink.startOfA = true;
            trackEdgeLink.startOfB = true;
            trackEdgeLink.usableDir = LinkDirection.linkDirBoth;
            var serializer = new XmlSerializer(typeof(TrackEdgeLink));

            serializer.Serialize(writer, trackEdgeLink, namespaces);

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
            topoArea.trackEdges = new() { new() };
            topoArea.trackEdgeLinks = new() { new() };
            var serializer = new XmlSerializer(typeof(TopoArea));

            serializer.Serialize(writer, topoArea, namespaces);

            string xml = writer.ToString();

            validate(xml);

            Assert.Equal("", validationOutput);

        }
        [Fact]

        public void TrackEdgePoint()

        {

            namespaces.Add("infra", "https://erju.org/infra");

            TrackEdgePoint trackEdgePoint = new TrackEdgePoint();
            trackEdgePoint.TrackEdge = "HelloWorld";
            trackEdgePoint.pos = 4294967295;
            var serializer = new XmlSerializer(typeof(TrackEdgePoint));

            serializer.Serialize(writer, trackEdgePoint, namespaces);

            string xml = writer.ToString();

            validate(xml);

            Assert.Equal("", validationOutput);

        }
        [Fact]

        public void DirTrackEdgePoint()

        {

            namespaces.Add("infra", "https://erju.org/infra");

            DirTrackEdgePoint dirTrackEdgePoint = new DirTrackEdgePoint();
            dirTrackEdgePoint.TrackEdge = "HelloWorld";
            dirTrackEdgePoint.pos = 4294967295;
            dirTrackEdgePoint.sameDir = true;
            var serializer = new XmlSerializer(typeof(DirTrackEdgePoint));

            serializer.Serialize(writer, dirTrackEdgePoint, namespaces);

            string xml = writer.ToString();

            validate(xml);

            Assert.Equal("", validationOutput);

        }
        [Fact]

        public void TrackEdgeSection()

        {

            namespaces.Add("infra", "https://erju.org/infra");

            TrackEdgeSection trackEdgeSection = new TrackEdgeSection();
            trackEdgeSection.TrackEdge = "HelloWorld";
            trackEdgeSection.skipFromStart = 4294967295;
            trackEdgeSection.skipFromEnd = 4294967295;
            var serializer = new XmlSerializer(typeof(TrackEdgeSection));

            serializer.Serialize(writer, trackEdgeSection, namespaces);

            string xml = writer.ToString();

            validate(xml);

            Assert.Equal("", validationOutput);

        }
        [Fact]

        public void DirTrackEdge()

        {

            namespaces.Add("infra", "https://erju.org/infra");

            DirTrackEdge dirTrackEdge = new DirTrackEdge();
            dirTrackEdge.TrackEdge = "HelloWorld";
            dirTrackEdge.sameDir = true;
            var serializer = new XmlSerializer(typeof(DirTrackEdge));

            serializer.Serialize(writer, dirTrackEdge, namespaces);

            string xml = writer.ToString();

            validate(xml);

            Assert.Equal("", validationOutput);

        }
        [Fact]

        public void LinkedPath()

        {

            namespaces.Add("infra", "https://erju.org/infra");

            LinkedPath linkedPath = new LinkedPath();
            linkedPath.dirTrackEdges = new() { new() };
            linkedPath.skipFromStart = 4294967295;
            linkedPath.skipFromEnd = 4294967295;
            var serializer = new XmlSerializer(typeof(LinkedPath));

            serializer.Serialize(writer, linkedPath, namespaces);

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
            geometryArea.trackEdgeGeometries = new() { new() };
            geometryArea.sampledTrackEdgeGeometries = new() { new() };
            var serializer = new XmlSerializer(typeof(GeometryArea));

            serializer.Serialize(writer, geometryArea, namespaces);

            string xml = writer.ToString();

            validate(xml);

            Assert.Equal("", validationOutput);

        }
        [Fact]

        public void TrackEdgeGeometry()

        {

            namespaces.Add("infra", "https://erju.org/infra");

            TrackEdgeGeometry trackEdgeGeometry = new TrackEdgeGeometry();
            trackEdgeGeometry.Id = "HelloWorld";
            trackEdgeGeometry.horizontalAlignment = new() { new() {arc=new() } };
            trackEdgeGeometry.verticalAlignment = new() { new() { arc = new() } };
            trackEdgeGeometry.cantSamples = new() { new() };
            var serializer = new XmlSerializer(typeof(TrackEdgeGeometry));

            serializer.Serialize(writer, trackEdgeGeometry, namespaces);

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
            var serializer = new XmlSerializer(typeof(HorizontalSegment));

            serializer.Serialize(writer, horizontalSegment, namespaces);

            string xml = writer.ToString();

            validate(xml);

            Assert.Equal("", validationOutput);

        }
        [Fact]

        public void HorizontalLine()

        {

            namespaces.Add("infra", "https://erju.org/infra");

            HorizontalLine horizontalLine = new HorizontalLine();
            horizontalLine.pos = 1.0;
            horizontalLine.azimuth = 1.0;
            var serializer = new XmlSerializer(typeof(HorizontalLine));

            serializer.Serialize(writer, horizontalLine, namespaces);

            string xml = writer.ToString();

            validate(xml);

            Assert.Equal("", validationOutput);

        }
        [Fact]

        public void HorizontalArc()

        {

            namespaces.Add("infra", "https://erju.org/infra");

            HorizontalArc horizontalArc = new HorizontalArc();
            horizontalArc.pos = 1.0;
            horizontalArc.azimuth = 1.0;
            var serializer = new XmlSerializer(typeof(HorizontalArc));

            serializer.Serialize(writer, horizontalArc, namespaces);

            string xml = writer.ToString();

            validate(xml);

            Assert.Equal("", validationOutput);

        }
        [Fact]

        public void HorizontalTransition()

        {

            namespaces.Add("infra", "https://erju.org/infra");

            HorizontalTransition horizontalTransition = new HorizontalTransition();
            horizontalTransition.pos = 1.0;
            horizontalTransition.azimuth = 1.0;
            horizontalTransition.radius = 1.0;
            horizontalTransition.type = TransitionType.clothoidCurve;
            var serializer = new XmlSerializer(typeof(HorizontalTransition));

            serializer.Serialize(writer, horizontalTransition, namespaces);

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
            var serializer = new XmlSerializer(typeof(VerticalSegment));

            serializer.Serialize(writer, verticalSegment, namespaces);

            string xml = writer.ToString();

            validate(xml);

            Assert.Equal("", validationOutput);

        }
        [Fact]

        public void VerticalLine()

        {

            namespaces.Add("infra", "https://erju.org/infra");

            VerticalLine verticalLine = new VerticalLine();
            verticalLine.pos = 1.0;
            verticalLine.slope = 1.0;
            var serializer = new XmlSerializer(typeof(VerticalLine));

            serializer.Serialize(writer, verticalLine, namespaces);

            string xml = writer.ToString();

            validate(xml);

            Assert.Equal("", validationOutput);

        }
        [Fact]

        public void VerticalArc()

        {

            namespaces.Add("infra", "https://erju.org/infra");

            VerticalArc verticalArc = new VerticalArc();
            verticalArc.pos = 1.0;
            verticalArc.slope = 1.0;
            verticalArc.radius = 1.0;
            var serializer = new XmlSerializer(typeof(VerticalArc));

            serializer.Serialize(writer, verticalArc, namespaces);

            string xml = writer.ToString();

            validate(xml);

            Assert.Equal("", validationOutput);

        }
        [Fact]

        public void CantSamplePoint()

        {

            namespaces.Add("infra", "https://erju.org/infra");

            CantSamplePoint cantSamplePoint = new CantSamplePoint();
            cantSamplePoint.pos = 4294967295;
            cantSamplePoint.appliedCant = 1.0;
            cantSamplePoint.cant = -2147483647;
            var serializer = new XmlSerializer(typeof(CantSamplePoint));

            serializer.Serialize(writer, cantSamplePoint, namespaces);

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
            sampledGeometryArea.Name = "HelloWorld";
            sampledGeometryArea.sampledTrackEdgeGeometries = new() { new() };
            var serializer = new XmlSerializer(typeof(SampledGeometryArea));

            serializer.Serialize(writer, sampledGeometryArea, namespaces);

            string xml = writer.ToString();

            validate(xml);

            Assert.Equal("", validationOutput);

        }
        [Fact]

        public void SampledTrackEdgeGeometry()

        {

            namespaces.Add("infra", "https://erju.org/infra");

            SampledTrackEdgeGeometry sampledTrackEdgeGeometry = new SampledTrackEdgeGeometry();
            sampledTrackEdgeGeometry.Id = "HelloWorld";
            sampledTrackEdgeGeometry.slopes = new() { new() };
            sampledTrackEdgeGeometry.curves = new() { new() };
            sampledTrackEdgeGeometry.cants = new() { new() };
            var serializer = new XmlSerializer(typeof(SampledTrackEdgeGeometry));

            serializer.Serialize(writer, sampledTrackEdgeGeometry, namespaces);

            string xml = writer.ToString();

            validate(xml);

            Assert.Equal("", validationOutput);

        }
        [Fact]

        public void SlopeSamplePoint()

        {

            namespaces.Add("infra", "https://erju.org/infra");

            SlopeSamplePoint slopeSamplePoint = new SlopeSamplePoint();
            slopeSamplePoint.pos = 4294967295;
            slopeSamplePoint.slope = -2147483647;
            var serializer = new XmlSerializer(typeof(SlopeSamplePoint));

            serializer.Serialize(writer, slopeSamplePoint, namespaces);

            string xml = writer.ToString();

            validate(xml);

            Assert.Equal("", validationOutput);

        }
        [Fact]

        public void CurveSamplePoint()

        {

            namespaces.Add("infra", "https://erju.org/infra");

            CurveSamplePoint curveSamplePoint = new CurveSamplePoint();
            curveSamplePoint.pos = 4294967295;
            curveSamplePoint.radius = -2147483647;
            var serializer = new XmlSerializer(typeof(CurveSamplePoint));

            serializer.Serialize(writer, curveSamplePoint, namespaces);

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
            simplePoint.MainTrack = "HelloWorld";
            simplePoint.BranchTrack = "HelloWorld";
            var serializer = new XmlSerializer(typeof(SimplePoint));

            serializer.Serialize(writer, simplePoint, namespaces);

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
            slipCrossing.simplePoints = new() { new() };
            var serializer = new XmlSerializer(typeof(SlipCrossing));

            serializer.Serialize(writer, slipCrossing, namespaces);

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
            derailer.TrackEdge = "HelloWorld";
            derailer.pos = 4294967295;
            derailer.sameDir = true;
            derailer.reversalTime = 4294967295;
            derailer.derailToRight = true;
            var serializer = new XmlSerializer(typeof(Derailer));

            serializer.Serialize(writer, derailer, namespaces);

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
            crossing.trackEdgePoints = new() { new() };
            var serializer = new XmlSerializer(typeof(Crossing));

            serializer.Serialize(writer, crossing, namespaces);

            string xml = writer.ToString();

            validate(xml);

            Assert.Equal("", validationOutput);

        }
        [Fact]

        public void SwitchedCrossing()

        {

            namespaces.Add("infra", "https://erju.org/infra");

            SwitchedCrossing switchedCrossing = new SwitchedCrossing();
            switchedCrossing.Id = "HelloWorld";
            switchedCrossing.Name = "HelloWorld";
            switchedCrossing.trackEdgeLinks = new() { new() };
            var serializer = new XmlSerializer(typeof(SwitchedCrossing));

            serializer.Serialize(writer, switchedCrossing, namespaces);

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
            baliseGroup.Name = "HelloWorld";
            baliseGroup.nidBG = 4294967295;
            baliseGroup.nidC = 4294967295;
            baliseGroup.balises = new() { new() };
            baliseGroup.bgFunction = BaliseGroupFunction.location;
            baliseGroup.locationAccuracy = 4294967295;
            var serializer = new XmlSerializer(typeof(BaliseGroup));

            serializer.Serialize(writer, baliseGroup, namespaces);

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
            balise.TrackEdge = "HelloWorld";
            balise.pos = 4294967295;
            var serializer = new XmlSerializer(typeof(Balise));

            serializer.Serialize(writer, balise, namespaces);

            string xml = writer.ToString();

            validate(xml);

            Assert.Equal("", validationOutput);

        }
        [Fact]

        public void PropertiesArea()

        {

            namespaces.Add("infra", "https://erju.org/infra");

            PropertiesArea propertiesArea = new PropertiesArea();
            propertiesArea.Id = "HelloWorld";
            propertiesArea.Name = "HelloWorld";
            propertiesArea.gauge = 4294967295;
            propertiesArea.loadingGaugeType = LoadingGaugeType.loadingGaugeIncompatible;
            propertiesArea.trackEdgeGauges = new() { new() };
            propertiesArea.trackEdgeLoadingGauges = new() { new() };
            propertiesArea.trackConditions = new() { new() };
            propertiesArea.secondaryTracks = new() { new() };
            propertiesArea.shuntingTracks = new() { new() };
            propertiesArea.currentLimitations = new() { new() };
            propertiesArea.permittedBrakingDistances = new() { new() };
            propertiesArea.preferredSameDir = new() { new() };
            propertiesArea.preferredOppositeDir = new() { new() };
            var serializer = new XmlSerializer(typeof(PropertiesArea));

            serializer.Serialize(writer, propertiesArea, namespaces);

            string xml = writer.ToString();

            validate(xml);

            Assert.Equal("", validationOutput);

        }
        [Fact]

        public void TrackEdgeGauge()

        {

            namespaces.Add("infra", "https://erju.org/infra");

            TrackEdgeGauge trackEdgeGauge = new TrackEdgeGauge();
            trackEdgeGauge.trackSections = new() { new() };
            trackEdgeGauge.gauge = 4294967295;
            var serializer = new XmlSerializer(typeof(TrackEdgeGauge));

            serializer.Serialize(writer, trackEdgeGauge, namespaces);

            string xml = writer.ToString();

            validate(xml);

            Assert.Equal("", validationOutput);

        }
        [Fact]

        public void TrackEdgeLoadingGauge()

        {

            namespaces.Add("infra", "https://erju.org/infra");

            TrackEdgeLoadingGauge trackEdgeLoadingGauge = new TrackEdgeLoadingGauge();
            trackEdgeLoadingGauge.trackSections = new() { new() };
            trackEdgeLoadingGauge.loadingGaugeType = LoadingGaugeType.loadingGaugeIncompatible;
            var serializer = new XmlSerializer(typeof(TrackEdgeLoadingGauge));

            serializer.Serialize(writer, trackEdgeLoadingGauge, namespaces);

            string xml = writer.ToString();

            validate(xml);

            Assert.Equal("", validationOutput);

        }
        [Fact]

        public void TrackCondition()

        {

            namespaces.Add("infra", "https://erju.org/infra");

            TrackCondition trackCondition = new TrackCondition();
            trackCondition.trackSections = new() { new() };
            trackCondition.type = ConditionType.powerlessLowPanthograph;
            var serializer = new XmlSerializer(typeof(TrackCondition));

            serializer.Serialize(writer, trackCondition, namespaces);

            string xml = writer.ToString();

            validate(xml);

            Assert.Equal("", validationOutput);

        }
        [Fact]

        public void CurrentLimitation()

        {

            namespaces.Add("infra", "https://erju.org/infra");

            CurrentLimitation currentLimitation = new CurrentLimitation();
            currentLimitation.trackSections = new() { new() };
            currentLimitation.maxCurrent = 4294967295;
            var serializer = new XmlSerializer(typeof(CurrentLimitation));

            serializer.Serialize(writer, currentLimitation, namespaces);

            string xml = writer.ToString();

            validate(xml);

            Assert.Equal("", validationOutput);

        }
        [Fact]

        public void PermittedBrakingDistance()

        {

            namespaces.Add("infra", "https://erju.org/infra");

            PermittedBrakingDistance permittedBrakingDistance = new PermittedBrakingDistance();
            permittedBrakingDistance.trackSections = new() { new() };
            permittedBrakingDistance.pbdDist = 4294967295;
            permittedBrakingDistance.brakeType = BrakeType.serviceBrake;
            permittedBrakingDistance.pbdGradient = -2147483647;
            var serializer = new XmlSerializer(typeof(PermittedBrakingDistance));

            serializer.Serialize(writer, permittedBrakingDistance, namespaces);

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
            trackEdgeSpeedProfile.Name = "HelloWorld";
            trackEdgeSpeedProfile.staticSpeedProfile = new() { new() };
            trackEdgeSpeedProfile.axleLoadSpeedProfiles = new() { new() };
            trackEdgeSpeedProfile.sameDir = true;
            var serializer = new XmlSerializer(typeof(TrackEdgeSpeedProfile));

            serializer.Serialize(writer, trackEdgeSpeedProfile, namespaces);

            string xml = writer.ToString();

            validate(xml);

            Assert.Equal("", validationOutput);

        }
        [Fact]

        public void StaticSpeedLimit()

        {

            namespaces.Add("infra", "https://erju.org/infra");

            StaticSpeedLimit staticSpeedLimit = new StaticSpeedLimit();
            staticSpeedLimit.pos = 4294967295;
            staticSpeedLimit.speed = 4294967295;
            staticSpeedLimit.specificStaticSpeedLimits = new() { new() {specificLimitType=new() } };
            var serializer = new XmlSerializer(typeof(StaticSpeedLimit));

            serializer.Serialize(writer, staticSpeedLimit, namespaces);

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

            string xml = writer.ToString();

            validate(xml);

            Assert.Equal("", validationOutput);

        }
        [Fact]

        public void SpeedLimitType()

        {

            namespaces.Add("infra", "https://erju.org/infra");

            SpeedLimitType speedLimitType = new SpeedLimitType();
            speedLimitType.otherCategory = OtherSpecificStaticSpeedProfileCategory.freightTrainP;
            var serializer = new XmlSerializer(typeof(SpeedLimitType));

            serializer.Serialize(writer, speedLimitType, namespaces);

            string xml = writer.ToString();

            validate(xml);

            Assert.Equal("", validationOutput);

        }
        [Fact]

        public void AxleLoadSpeedProfile()

        {

            namespaces.Add("infra", "https://erju.org/infra");

            AxleLoadSpeedProfile axleLoadSpeedProfile = new AxleLoadSpeedProfile();
            axleLoadSpeedProfile.startPos = 4294967295;
            axleLoadSpeedProfile.endPos = 4294967295;
            axleLoadSpeedProfile.speed = 4294967295;
            axleLoadSpeedProfile.axleLoadCategory = AxleLoadCategory.AL_A;
            var serializer = new XmlSerializer(typeof(AxleLoadSpeedProfile));

            serializer.Serialize(writer, axleLoadSpeedProfile, namespaces);

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
            mapArea.trackEdges = new() { new() };
            mapArea.funcElements = new() { new() {elementRef=new() } };
            var serializer = new XmlSerializer(typeof(MapArea));

            serializer.Serialize(writer, mapArea, namespaces);

            string xml = writer.ToString();

            validate(xml);

            Assert.Equal("", validationOutput);

        }
        [Fact]

        public void TrackEdgeProjection()

        {

            namespaces.Add("infra", "https://erju.org/infra");

            TrackEdgeProjection trackEdgeProjection = new TrackEdgeProjection();
            trackEdgeProjection.Id = "HelloWorld";
            trackEdgeProjection.coordinates = new() { new() };
            var serializer = new XmlSerializer(typeof(TrackEdgeProjection));

            serializer.Serialize(writer, trackEdgeProjection, namespaces);

            string xml = writer.ToString();

            validate(xml);

            Assert.Equal("", validationOutput);

        }
        [Fact]

        public void TrackEdgeCoordinate()

        {

            namespaces.Add("infra", "https://erju.org/infra");

            TrackEdgeCoordinate trackEdgeCoordinate = new TrackEdgeCoordinate();
            trackEdgeCoordinate.pos = 4294967295;
            trackEdgeCoordinate.x = 1.0;
            trackEdgeCoordinate.y = 1.0;
            trackEdgeCoordinate.z = 1.0;
            var serializer = new XmlSerializer(typeof(TrackEdgeCoordinate));

            serializer.Serialize(writer, trackEdgeCoordinate, namespaces);

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
            funcElementProjection.x = 1.0;
            funcElementProjection.y = 1.0;
            funcElementProjection.z = 1.0;
            var serializer = new XmlSerializer(typeof(FuncElementProjection));

            serializer.Serialize(writer, funcElementProjection, namespaces);

            string xml = writer.ToString();

            validate(xml);

            Assert.Equal("", validationOutput);

        }
        [Fact]

        public void FuncElementRef()

        {

            namespaces.Add("infra", "https://erju.org/infra");

            FuncElementRef funcElementRef = new FuncElementRef();
            funcElementRef.SimplePoint = "HelloWorld";
            var serializer = new XmlSerializer(typeof(FuncElementRef));

            serializer.Serialize(writer, funcElementRef, namespaces);

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
            eTCSMarker.TrackEdge = "HelloWorld";
            eTCSMarker.pos = 4294967295;
            eTCSMarker.sameDir = true;
            eTCSMarker.markerFunctionStop = true;
            var serializer = new XmlSerializer(typeof(ETCSMarker));

            serializer.Serialize(writer, eTCSMarker, namespaces);

            string xml = writer.ToString();

            validate(xml);

            Assert.Equal("", validationOutput);

        }
        [Fact]

        public void StopLocation()

        {

            namespaces.Add("infra", "https://erju.org/infra");

            StopLocation stopLocation = new StopLocation();
            stopLocation.Id = "HelloWorld";
            stopLocation.Name = "HelloWorld";
            stopLocation.TrackEdge = "HelloWorld";
            stopLocation.pos = 4294967295;
            stopLocation.sameDir = true;
            stopLocation.stopTrainLimit = new();
            stopLocation.TimingPoint = "HelloWorld";
            stopLocation.trainLoadType = TrainLoadType.passengerTrain;
            stopLocation.doorOpeningSide = DoorOpeningSide.noSide;
            var serializer = new XmlSerializer(typeof(StopLocation));

            serializer.Serialize(writer, stopLocation, namespaces);

            string xml = writer.ToString();

            validate(xml);

            Assert.Equal("", validationOutput);

        }
        [Fact]

        public void StopTrainLimit()

        {

            namespaces.Add("infra", "https://erju.org/infra");

            StopTrainLimit stopTrainLimit = new StopTrainLimit();
            stopTrainLimit.trainMaxLength = 4294967295;
            var serializer = new XmlSerializer(typeof(StopTrainLimit));

            serializer.Serialize(writer, stopTrainLimit, namespaces);

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
            platformEdge.stopLocations = new() { new() };
            var serializer = new XmlSerializer(typeof(PlatformEdge));

            serializer.Serialize(writer, platformEdge, namespaces);

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
            platform.platformEdges = new() { new() { linearLocation=new()} };
            var serializer = new XmlSerializer(typeof(Platform));

            serializer.Serialize(writer, platform, namespaces);

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
            operationalPoint.travelTimeMeasurementPoints = new() { new() };
            operationalPoint.type = OPType.station;
            operationalPoint.platforms = new() { new() };
            var serializer = new XmlSerializer(typeof(OperationalPoint));

            serializer.Serialize(writer, operationalPoint, namespaces);

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
            timingPoint.TrackEdge = "HelloWorld";
            timingPoint.pos = 4294967295;
            var serializer = new XmlSerializer(typeof(TimingPoint));

            serializer.Serialize(writer, timingPoint, namespaces);

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
            tunnel.tunnelTubes = new() { new() };
            var serializer = new XmlSerializer(typeof(Tunnel));

            serializer.Serialize(writer, tunnel, namespaces);

            string xml = writer.ToString();

            validate(xml);

            Assert.Equal("", validationOutput);

        }
        [Fact]

        public void TunnelTube()

        {

            namespaces.Add("infra", "https://erju.org/infra");

            TunnelTube tunnelTube = new TunnelTube();
            tunnelTube.trackSections = new() { new() };
            tunnelTube.crossSection = 4294967295;
            var serializer = new XmlSerializer(typeof(TunnelTube));

            serializer.Serialize(writer, tunnelTube, namespaces);

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
            bridge.trackEdgeSections = new() { new() };
            var serializer = new XmlSerializer(typeof(Bridge));

            serializer.Serialize(writer, bridge, namespaces);

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
            underpass.trackEdgeSections = new() { new() };
            var serializer = new XmlSerializer(typeof(Underpass));

            serializer.Serialize(writer, underpass, namespaces);

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
            tvpSection.trackSections = new() { new() };
            tvpSection.trainDetectors = new() { new() };
            var serializer = new XmlSerializer(typeof(TvpSection));

            serializer.Serialize(writer, tvpSection, namespaces);

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
            trainDetector.TrackEdge = "HelloWorld";
            trainDetector.pos = 4294967295;
            trainDetector.type = TrainDetectorType.axleCounter;
            var serializer = new XmlSerializer(typeof(TrainDetector));

            serializer.Serialize(writer, trainDetector, namespaces);

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
            levelCrossing.trackEdgeSections = new() { new() };
            var serializer = new XmlSerializer(typeof(LevelCrossing));

            serializer.Serialize(writer, levelCrossing, namespaces);

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
            nationalBorder.Name = "HelloWorld";
            nationalBorder.TrackEdge = "HelloWorld";
            nationalBorder.pos = 4294967295;
            nationalBorder.FromCountryCode = "HelloWorld";
            nationalBorder.ToCountryCode = "HelloWorld";
            var serializer = new XmlSerializer(typeof(NationalBorder));

            serializer.Serialize(writer, nationalBorder, namespaces);

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
            bufferStop.Name = "HelloWorld";
            bufferStop.TrackEdge = "HelloWorld";
            bufferStop.pos = 4294967295;
            bufferStop.sameDir = true;
            bufferStop.isSwitchable = true;
            var serializer = new XmlSerializer(typeof(BufferStop));

            serializer.Serialize(writer, bufferStop, namespaces);

            string xml = writer.ToString();

            validate(xml);

            Assert.Equal("", validationOutput);

        }
        [Fact]

        public void FunctionalArea()

        {

            namespaces.Add("infra", "https://erju.org/infra");

            FunctionalArea functionalArea = new FunctionalArea();
            functionalArea.Id = "HelloWorld";
            functionalArea.opPoints = new() { new() };
            functionalArea.timingPoints = new() { new() };
            functionalArea.simplePoints = new() { new() };
            functionalArea.slipCrossings = new() { new() };
            functionalArea.derailers = new() { new() };
            functionalArea.crossings = new() { new() };
            functionalArea.switchedCrossings = new() { new() };
            functionalArea.trainDetectors = new() { new() };
            functionalArea.baliseGroups = new() { new() };
            functionalArea.etcsMarkers = new() { new() };
            functionalArea.stopLocations = new() { new() };
            functionalArea.teSpeedProfiles = new() { new() };
            functionalArea.tunnels = new() { new() };
            functionalArea.bridges = new() { new() };
            functionalArea.underpasses = new() { new() };
            functionalArea.tvps = new() { new() };
            functionalArea.levelCrossings = new() { new() };
            functionalArea.nationalBorders = new() { new() };
            functionalArea.bufferStops = new() { new() };
            var serializer = new XmlSerializer(typeof(FunctionalArea));

            serializer.Serialize(writer, functionalArea, namespaces);

            string xml = writer.ToString();

            validate(xml);

            Assert.Equal("", validationOutput);

        }
        [Fact]

        public void Infrastructure()

        {

            namespaces.Add("infra", "https://erju.org/infra");

            Infrastructure infrastructure = new Infrastructure();
            infrastructure.topoAreas = new() { new() };
            infrastructure.geometryAreas = new() { new() };
            infrastructure.sampledGeometryAreas = new() { new() };
            infrastructure.functionalAreas = new() { new() };
            infrastructure.propertiesAreas = new() { new() };
            infrastructure.mapAreas = new() { new() };
            var serializer = new XmlSerializer(typeof(Infrastructure));

            serializer.Serialize(writer, infrastructure, namespaces);

            string xml = writer.ToString();

            validate(xml);

            Assert.Equal("", validationOutput);

        }

    }
}