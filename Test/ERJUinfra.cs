using System.Xml.Schema;
using System.Xml;
using System.Xml.Serialization;
using infra;
using System.Security.Cryptography.X509Certificates;

namespace Test
{
    
    public class ERJUInfra
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

           namespaces.Add("infra", "https://erju.org/infra");



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

           namespaces.Add("infra", "https://erju.org/infra");



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

           namespaces.Add("infra", "https://erju.org/infra");



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

           namespaces.Add("infra", "https://erju.org/infra");



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

           namespaces.Add("infra", "https://erju.org/infra");



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

           namespaces.Add("infra", "https://erju.org/infra");



            HorizontalSegment horizontalSegment = new HorizontalSegment();

            var serializer = new XmlSerializer(typeof(HorizontalSegment));



            serializer.Serialize(writer, horizontalSegment, namespaces);



            // Get the serialized XML as a string

            string xml = writer.ToString();



            validate(xml);



            Assert.Equal("The element 'horizontalSegment' in namespace 'https://erju.org/infra' has incomplete content. List of possible elements expected: 'line' in namespace 'https://erju.org/infra'.", validationOutput);

        }

        [Fact]

        public void HorizontalLine()

        {

           namespaces.Add("infra", "https://erju.org/infra");



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

           namespaces.Add("infra", "https://erju.org/infra");



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

           namespaces.Add("infra", "https://erju.org/infra");



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

           namespaces.Add("infra", "https://erju.org/infra");



            VerticalSegment verticalSegment = new VerticalSegment();

            var serializer = new XmlSerializer(typeof(VerticalSegment));



            serializer.Serialize(writer, verticalSegment, namespaces);



            // Get the serialized XML as a string

            string xml = writer.ToString();



            validate(xml);



            Assert.Equal("The element 'verticalSegment' in namespace 'https://erju.org/infra' has incomplete content. List of possible elements expected: 'line' in namespace 'https://erju.org/infra'.", validationOutput);

        }

        [Fact]

        public void VerticalLine()

        {

           namespaces.Add("infra", "https://erju.org/infra");



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

           namespaces.Add("infra", "https://erju.org/infra");



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

           namespaces.Add("infra", "https://erju.org/infra");



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

           namespaces.Add("infra", "https://erju.org/infra");



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

           namespaces.Add("infra", "https://erju.org/infra");



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

           namespaces.Add("infra", "https://erju.org/infra");



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

           namespaces.Add("infra", "https://erju.org/infra");



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

           namespaces.Add("infra", "https://erju.org/infra");



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

           namespaces.Add("infra", "https://erju.org/infra");



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

           namespaces.Add("infra", "https://erju.org/infra");



            Derailer derailer = new Derailer();

            var serializer = new XmlSerializer(typeof(Derailer));



            serializer.Serialize(writer, derailer, namespaces);



            // Get the serialized XML as a string

            string xml = writer.ToString();



            validate(xml);



            Assert.Equal("The element 'derailer' in namespace 'https://erju.org/infra' has incomplete content. List of possible elements expected: 'trackEdgePoint' in namespace 'https://erju.org/infra'.", validationOutput);

        }

        [Fact]

        public void Crossing()

        {

           namespaces.Add("infra", "https://erju.org/infra");



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

           namespaces.Add("infra", "https://erju.org/infra");



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

           namespaces.Add("infra", "https://erju.org/infra");



            Balise balise = new Balise();

            var serializer = new XmlSerializer(typeof(Balise));



            serializer.Serialize(writer, balise, namespaces);



            // Get the serialized XML as a string

            string xml = writer.ToString();



            validate(xml);



            Assert.Equal("The element 'balise' in namespace 'https://erju.org/infra' has incomplete content. List of possible elements expected: 'trackEdgePoint' in namespace 'https://erju.org/infra'.", validationOutput);

        }

        [Fact]

        public void PropertiesArea()

        {

           namespaces.Add("infra", "https://erju.org/infra");



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

           namespaces.Add("infra", "https://erju.org/infra");



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

           namespaces.Add("infra", "https://erju.org/infra");



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

           namespaces.Add("infra", "https://erju.org/infra");



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

           namespaces.Add("infra", "https://erju.org/infra");



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

           namespaces.Add("infra", "https://erju.org/infra");



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

           namespaces.Add("infra", "https://erju.org/infra");



            MileageMarker milageMarker = new MileageMarker();

            var serializer = new XmlSerializer(typeof(MileageMarker));



            serializer.Serialize(writer, milageMarker, namespaces);



            // Get the serialized XML as a string

            string xml = writer.ToString();



            validate(xml);



            Assert.Equal("", validationOutput);

        }

        [Fact]

        public void TrackEdgeMilageLineSegment()

        {

           namespaces.Add("infra", "https://erju.org/infra");



            TrackEdgeMileageLineSegment trackEdgeMilageLineSegment = new TrackEdgeMileageLineSegment();

            var serializer = new XmlSerializer(typeof(TrackEdgeMileageLineSegment));



            serializer.Serialize(writer, trackEdgeMilageLineSegment, namespaces);



            // Get the serialized XML as a string

            string xml = writer.ToString();



            validate(xml);



            Assert.Equal("The element 'trackEdgeMileageLineSegment' in namespace 'https://erju.org/infra' has incomplete content. List of possible elements expected: 'points' in namespace 'https://erju.org/infra'.", validationOutput);

        }

        [Fact]

        public void MilageLine()

        {

           namespaces.Add("infra", "https://erju.org/infra");



            MileageLine milageLine = new MileageLine();

            var serializer = new XmlSerializer(typeof(MileageLine));



            serializer.Serialize(writer, milageLine, namespaces);



            // Get the serialized XML as a string

            string xml = writer.ToString();



            validate(xml);



            Assert.Equal("The element 'mileageLine' in namespace 'https://erju.org/infra' has incomplete content. List of possible elements expected: 'trackEdges' in namespace 'https://erju.org/infra'.", validationOutput);

        }

        [Fact]

        public void MilageArea()

        {

           namespaces.Add("infra", "https://erju.org/infra");



            MileageArea milageArea = new MileageArea();

            var serializer = new XmlSerializer(typeof(MileageArea));



            serializer.Serialize(writer, milageArea, namespaces);



            // Get the serialized XML as a string

            string xml = writer.ToString();



            validate(xml);



            Assert.Equal("The element 'mileageArea' in namespace 'https://erju.org/infra' has incomplete content. List of possible elements expected: 'mileageLines' in namespace 'https://erju.org/infra'.", validationOutput);

        }

        [Fact]

        public void MapArea()

        {

           namespaces.Add("infra", "https://erju.org/infra");



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

           namespaces.Add("infra", "https://erju.org/infra");



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

           namespaces.Add("infra", "https://erju.org/infra");



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

           namespaces.Add("infra", "https://erju.org/infra");



            FuncElementProjection funcElementProjection = new FuncElementProjection();

            var serializer = new XmlSerializer(typeof(FuncElementProjection));



            serializer.Serialize(writer, funcElementProjection, namespaces);



            // Get the serialized XML as a string

            string xml = writer.ToString();



            validate(xml);



            Assert.Equal("The element 'funcElementProjection' in namespace 'https://erju.org/infra' has incomplete content. List of possible elements expected: 'elementRef' in namespace 'https://erju.org/infra'.", validationOutput);

        }

        [Fact]

        public void FuncElementRef()

        {

           namespaces.Add("infra", "https://erju.org/infra");



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

           namespaces.Add("infra", "https://erju.org/infra");



            ETCSMarker eTCSMarker = new ETCSMarker();

            var serializer = new XmlSerializer(typeof(ETCSMarker));



            serializer.Serialize(writer, eTCSMarker, namespaces);



            // Get the serialized XML as a string

            string xml = writer.ToString();



            validate(xml);



            Assert.Equal("The element 'eTCSMarker' in namespace 'https://erju.org/infra' has incomplete content. List of possible elements expected: 'dirTrackEdgePoint' in namespace 'https://erju.org/infra'.", validationOutput);

        }

        [Fact]

        public void StopLocation()

        {

           namespaces.Add("infra", "https://erju.org/infra");
            StopLocation stopLocation = new StopLocation();

            var serializer = new XmlSerializer(typeof(StopLocation));



            serializer.Serialize(writer, stopLocation, namespaces);



            // Get the serialized XML as a string

            string xml = writer.ToString();



            validate(xml);



            Assert.Equal("The element 'stopLocation' in namespace 'https://erju.org/infra' has incomplete content. List of possible elements expected: 'trackEdgePoint' in namespace 'https://erju.org/infra'.", validationOutput);

        }

        [Fact]

        public void StopTrainLimitLength()

        {

           namespaces.Add("infra", "https://erju.org/infra");



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

           namespaces.Add("infra", "https://erju.org/infra");



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

           namespaces.Add("infra", "https://erju.org/infra");



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

           namespaces.Add("infra", "https://erju.org/infra");



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

           namespaces.Add("infra", "https://erju.org/infra");



            StopTrainLimit stopTrainLimit = new StopTrainLimit();

            var serializer = new XmlSerializer(typeof(StopTrainLimit));



            serializer.Serialize(writer, stopTrainLimit, namespaces);



            // Get the serialized XML as a string

            string xml = writer.ToString();



            validate(xml);



            Assert.Equal("The element 'stopTrainLimit' in namespace 'https://erju.org/infra' has incomplete content. List of possible elements expected: 'trainLimitLength' in namespace 'https://erju.org/infra'.", validationOutput);

        }

        [Fact]

        public void PlatformEdge()

        {

           namespaces.Add("infra", "https://erju.org/infra");



            PlatformEdge platformEdge = new PlatformEdge();

            var serializer = new XmlSerializer(typeof(PlatformEdge));



            serializer.Serialize(writer, platformEdge, namespaces);



            // Get the serialized XML as a string

            string xml = writer.ToString();



            validate(xml);



            Assert.Equal("The element 'platformEdge' in namespace 'https://erju.org/infra' has incomplete content. List of possible elements expected: 'linearLocation' in namespace 'https://erju.org/infra'.", validationOutput);

        }

        [Fact]

        public void Platform()

        {

           namespaces.Add("infra", "https://erju.org/infra");



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

           namespaces.Add("infra", "https://erju.org/infra");



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

           namespaces.Add("infra", "https://erju.org/infra");



            TimingPoint timingPoint = new TimingPoint();

            var serializer = new XmlSerializer(typeof(TimingPoint));



            serializer.Serialize(writer, timingPoint, namespaces);



            // Get the serialized XML as a string

            string xml = writer.ToString();



            validate(xml);



            Assert.Equal("The element 'timingPoint' in namespace 'https://erju.org/infra' has incomplete content. List of possible elements expected: 'trackEdgePoint' in namespace 'https://erju.org/infra'.", validationOutput);

        }

        [Fact]

        public void TimingPointObject()

        {

           namespaces.Add("infra", "https://erju.org/infra");



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

           namespaces.Add("infra", "https://erju.org/infra");



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