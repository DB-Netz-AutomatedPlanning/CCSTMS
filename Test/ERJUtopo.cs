using System.Xml.Schema;
using System.Xml;
using System.Xml.Serialization;
using topo;
using System.Security.Cryptography.X509Certificates;

namespace Test
{
    
    public class ERJUtopo
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

            namespaces.Add("topo", "https://erju.org/topo");



            StopTrainLimitSize stopTrainLimitSize = new StopTrainLimitSize();

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

            namespaces.Add("topo", "https://erju.org/topo");



            StopTrainLimit stopTrainLimit = new StopTrainLimit();

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

            var serializer = new XmlSerializer(typeof(FunctionalArea));



            serializer.Serialize(writer, functionalArea, namespaces);



            // Get the serialized XML as a string

            string xml = writer.ToString();



            validate(xml);



            Assert.Equal("", validationOutput);

        }
    }
}