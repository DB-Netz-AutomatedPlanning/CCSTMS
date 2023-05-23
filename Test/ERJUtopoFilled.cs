using System.Xml.Schema;
using System.Xml;
using System.Xml.Serialization;
using topo;
using System.Security.Cryptography.X509Certificates;

namespace Test
{
    
    public class ERJUtopoFilled
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
            settings.Schemas.Add(null, "topo.xsd");

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
            namespaces.Add("topo", "https://erju.org/topo");

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
            namespaces.Add("topo", "https://erju.org/topo");

            TrackEdgeLink trackEdgeLink = new TrackEdgeLink();

            trackEdgeLink.Id = "HelloWorld";
            trackEdgeLink.TrackEdgeA = "HelloWorld";
            trackEdgeLink.TrackEdgeB = "HelloWorld";
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
            namespaces.Add("topo", "https://erju.org/topo");

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
            namespaces.Add("topo", "https://erju.org/topo");

            TrackEdgePoint trackEdgePoint = new TrackEdgePoint();

            trackEdgePoint.TrackEdge = "HelloWorld";
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
        public void TrackEdgeSection()
        {
            namespaces.Add("topo", "https://erju.org/topo");

            TrackEdgeSection trackEdgeSection = new TrackEdgeSection();

            trackEdgeSection.TrackEdge = "HelloWorld";
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
            namespaces.Add("topo", "https://erju.org/topo");

            DirTrackEdge dirTrackEdge = new DirTrackEdge();

            dirTrackEdge.TrackEdge = "HelloWorld";
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
            namespaces.Add("topo", "https://erju.org/topo");

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
            namespaces.Add("topo", "https://erju.org/topo");

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
            namespaces.Add("topo", "https://erju.org/topo");

            TrackEdgeGeometry trackEdgeGeometry = new TrackEdgeGeometry();

            trackEdgeGeometry.TrackEdge = "HelloWorld";
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
            namespaces.Add("topo", "https://erju.org/topo");

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
            namespaces.Add("topo", "https://erju.org/topo");

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
            namespaces.Add("topo", "https://erju.org/topo");

            HorizontalArc horizontalArc = new HorizontalArc();

            horizontalArc.p = 4294967295;
            horizontalArc.azimuth = 4294967295;
            horizontalArc.radius = 4294967295;
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
            namespaces.Add("topo", "https://erju.org/topo");

            HorizontalTransition horizontalTransition = new HorizontalTransition();

            horizontalTransition.p = 4294967295;
            horizontalTransition.azimuth = 4294967295;
            horizontalTransition.radius = 4294967295;
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
            namespaces.Add("topo", "https://erju.org/topo");

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
            namespaces.Add("topo", "https://erju.org/topo");

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
            namespaces.Add("topo", "https://erju.org/topo");

            VerticalArc verticalArc = new VerticalArc();

            verticalArc.p = 4294967295;
            verticalArc.slope = -2147483647;
            verticalArc.radius = 4294967295;
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
            namespaces.Add("topo", "https://erju.org/topo");

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
            namespaces.Add("topo", "https://erju.org/topo");

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
            namespaces.Add("topo", "https://erju.org/topo");

            SampledTrackEdgeGeometry sampledTrackEdgeGeometry = new SampledTrackEdgeGeometry();

            sampledTrackEdgeGeometry.TrackEdge = "HelloWorld";
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
            namespaces.Add("topo", "https://erju.org/topo");

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
            namespaces.Add("topo", "https://erju.org/topo");

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
            namespaces.Add("topo", "https://erju.org/topo");

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
            namespaces.Add("topo", "https://erju.org/topo");

            SlipCrossing slipCrossing = new SlipCrossing();

            slipCrossing.Id = "HelloWorld";
            slipCrossing.Name = "HelloWorld";
            slipCrossing.simplePoints = new() { new() };
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
            namespaces.Add("topo", "https://erju.org/topo");

            Derailer derailer = new Derailer();

            derailer.Id = "HelloWorld";
            derailer.Name = "HelloWorld";
            derailer.trackEdgePoint = new();
            derailer.reversalTime = 4294967295;
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
            namespaces.Add("topo", "https://erju.org/topo");

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
            namespaces.Add("topo", "https://erju.org/topo");

            BaliseGroup baliseGroup = new BaliseGroup();

            baliseGroup.Id = "HelloWorld";
            baliseGroup.nidBG = 4294967295;
            baliseGroup.nidC = 4294967295;
            baliseGroup.balises = new();
            baliseGroup.Name = "HelloWorld";
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
            namespaces.Add("topo", "https://erju.org/topo");

            Balise balise = new Balise();

            balise.trackEdgePoint = new();
            balise.positionInGroup = 4294967295;
            balise.BaliseTelegram = "HelloWorld";
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
            namespaces.Add("topo", "https://erju.org/topo");

            PropertiesArea propertiesArea = new PropertiesArea();

            propertiesArea.AreaId = "HelloWorld";
            propertiesArea.gauge = 4294967295;
            propertiesArea.loadingGaugeType = new();
            propertiesArea.trackEdgeGauges = new();
            propertiesArea.trackEdgeLoadingGauges = new();
            propertiesArea.trackConditions = new();
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
            namespaces.Add("topo", "https://erju.org/topo");

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
            namespaces.Add("topo", "https://erju.org/topo");

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
            namespaces.Add("topo", "https://erju.org/topo");

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
            namespaces.Add("topo", "https://erju.org/topo");

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
            namespaces.Add("topo", "https://erju.org/topo");

            PermittedBrakingDistance permittedBrakingDistance = new PermittedBrakingDistance();

            permittedBrakingDistance.trackSections = new();
            permittedBrakingDistance.brakeDist = 4294967295;
            var serializer = new XmlSerializer(typeof(PermittedBrakingDistance));

            serializer.Serialize(writer, permittedBrakingDistance, namespaces);

            // Get the serialized XML as a string
            string xml = writer.ToString();

            validate(xml);

            Assert.Equal("", validationOutput);
        }
        [Fact]
        public void MilageMarker()
        {
            namespaces.Add("topo", "https://erju.org/topo");

            MilageMarker milageMarker = new MilageMarker();

            milageMarker.p = 4294967295;
            milageMarker.v = 4294967295;
            var serializer = new XmlSerializer(typeof(MilageMarker));

            serializer.Serialize(writer, milageMarker, namespaces);

            // Get the serialized XML as a string
            string xml = writer.ToString();

            validate(xml);

            Assert.Equal("", validationOutput);
        }
        [Fact]
        public void TrackEdgeMilageLineSegment()
        {
            namespaces.Add("topo", "https://erju.org/topo");

            TrackEdgeMilageLineSegment trackEdgeMilageLineSegment = new TrackEdgeMilageLineSegment();

            trackEdgeMilageLineSegment.TrackEdge = "HelloWorld";
            trackEdgeMilageLineSegment.points = new();
            var serializer = new XmlSerializer(typeof(TrackEdgeMilageLineSegment));

            serializer.Serialize(writer, trackEdgeMilageLineSegment, namespaces);

            // Get the serialized XML as a string
            string xml = writer.ToString();

            validate(xml);

            Assert.Equal("", validationOutput);
        }
        [Fact]
        public void MilageLine()
        {
            namespaces.Add("topo", "https://erju.org/topo");

            MilageLine milageLine = new MilageLine();

            milageLine.Id = "HelloWorld";
            milageLine.trackEdges = new();
            var serializer = new XmlSerializer(typeof(MilageLine));

            serializer.Serialize(writer, milageLine, namespaces);

            // Get the serialized XML as a string
            string xml = writer.ToString();

            validate(xml);

            Assert.Equal("", validationOutput);
        }
        [Fact]
        public void MilageArea()
        {
            namespaces.Add("topo", "https://erju.org/topo");

            MilageArea milageArea = new MilageArea();

            milageArea.AreaId = "HelloWorld";
            milageArea.milageLines = new();
            var serializer = new XmlSerializer(typeof(MilageArea));

            serializer.Serialize(writer, milageArea, namespaces);

            // Get the serialized XML as a string
            string xml = writer.ToString();

            validate(xml);

            Assert.Equal("", validationOutput);
        }
        [Fact]
        public void MapArea()
        {
            namespaces.Add("topo", "https://erju.org/topo");

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
            namespaces.Add("topo", "https://erju.org/topo");

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
            namespaces.Add("topo", "https://erju.org/topo");

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
            namespaces.Add("topo", "https://erju.org/topo");

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
            namespaces.Add("topo", "https://erju.org/topo");

            FuncElementRef funcElementRef = new FuncElementRef();

            funcElementRef.SimplePoint = "HelloWorld";
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
            namespaces.Add("topo", "https://erju.org/topo");

            ETCSMarker eTCSMarker = new ETCSMarker();

            eTCSMarker.id = 4294967295;
            eTCSMarker.Name = "HelloWorld";
            eTCSMarker.trackEdgePoint = new();
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
            namespaces.Add("topo", "https://erju.org/topo");

            StopLocation stopLocation = new StopLocation();

            stopLocation.id = 4294967295;
            stopLocation.Name = "HelloWorld";
            stopLocation.trackEdgePoint = new();
            stopLocation.stopTrainLimit = new();
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
            namespaces.Add("topo", "https://erju.org/topo");

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
            namespaces.Add("topo", "https://erju.org/topo");

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
            namespaces.Add("topo", "https://erju.org/topo");

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
        public void StopTrainLimit()
        {
            namespaces.Add("topo", "https://erju.org/topo");

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
        public void PlatformEdge()
        {
            namespaces.Add("topo", "https://erju.org/topo");

            PlatformEdge platformEdge = new PlatformEdge();

            platformEdge.Id = "HelloWorld";
            platformEdge.Name = "HelloWorld";
            platformEdge.linearLocation = new();
            platformEdge.stopLocations = new() { new() };
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
            namespaces.Add("topo", "https://erju.org/topo");

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
            namespaces.Add("topo", "https://erju.org/topo");

            OperationalPoint operationalPoint = new OperationalPoint();

            operationalPoint.Id = "HelloWorld";
            operationalPoint.Name = "HelloWorld";
            operationalPoint.timingPoints = new() {new()};
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
            namespaces.Add("topo", "https://erju.org/topo");

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
            namespaces.Add("topo", "https://erju.org/topo");

            TimingPointObject timingPointObject = new TimingPointObject();

            timingPointObject.EtcsMarkerBoard = "HelloWorld";
            timingPointObject.Platform = "HelloWorld";
            timingPointObject.StopLocation = "HelloWorld";
            var serializer = new XmlSerializer(typeof(TimingPointObject));

            serializer.Serialize(writer, timingPointObject, namespaces);

            // Get the serialized XML as a string
            string xml = writer.ToString();

            validate(xml);

            Assert.Equal("", validationOutput);
        }
        [Fact]
        public void FunctionalArea()
        {
            namespaces.Add("topo", "https://erju.org/topo");

            FunctionalArea functionalArea = new FunctionalArea();

            functionalArea.AreaId = "HelloWorld";
            functionalArea.opPoints = new();
            functionalArea.timingPoints = new();
            functionalArea.simplePoints = new();
            functionalArea.slipCrossings = new();
            functionalArea.derailers = new();
            functionalArea.crossings = new();
            functionalArea.baliseGroups = new();
            var serializer = new XmlSerializer(typeof(FunctionalArea));

            serializer.Serialize(writer, functionalArea, namespaces);

            // Get the serialized XML as a string
            string xml = writer.ToString();

            validate(xml);

            Assert.Equal("", validationOutput);
        }


    }
}