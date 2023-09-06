using System.Xml.Schema;
using System.Xml;
using System.Xml.Serialization;
using eng;
using System.Security.Cryptography.X509Certificates;


namespace Test
{
    
    public class EngFilled
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

        public void BufferStop()

        {

            namespaces.Add("infra", "https://erju.org/infra");

            BufferStop bufferStop = new BufferStop();
            bufferStop.Id = "HelloWorld";
            bufferStop.dangerPoints = new() { new() };
            bufferStop.trackEdgeSections = new() { new() };
            bufferStop.bsType = BufferStopType.friction;
            var serializer = new XmlSerializer(typeof(BufferStop));

            serializer.Serialize(writer, bufferStop, namespaces);

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
            simplePoint.dangerPoints = new() { new() };
            var serializer = new XmlSerializer(typeof(SimplePoint));

            serializer.Serialize(writer, simplePoint, namespaces);

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
            crossing.dangerPoints = new() { new() };
            var serializer = new XmlSerializer(typeof(Crossing));

            serializer.Serialize(writer, crossing, namespaces);

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
            levelCrossing.dangerPoints = new() { new() };
            var serializer = new XmlSerializer(typeof(LevelCrossing));

            serializer.Serialize(writer, levelCrossing, namespaces);

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
            baliseGroup.m_version = ss026.ETCSVersion.v1_0;
            baliseGroup.q_link = true;
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
            balise._fixed= true;
            balise.q_updown = true;
            balise.m_dup = DuplicationType.noDuplicates;
            balise.m_mcount = 4294967295;
            balise.verticallyOriented = true;
            balise.standardSize = true;
            balise.etcsPackets = new() { new() {packet=new(){

             packet_0=new()
        }

    } };
            var serializer = new XmlSerializer(typeof(Balise));

            serializer.Serialize(writer, balise, namespaces);

            string xml = writer.ToString();

            validate(xml);

            Assert.Equal("", validationOutput);

        }
        [Fact]

        public void Sleepers()

        {

            namespaces.Add("infra", "https://erju.org/infra");

            Sleepers sleepers = new Sleepers();
            sleepers.Id = "HelloWorld";
            sleepers.trackEdgeSection = new() { new() };
            sleepers.type = SleepersType.unknownSleepersType;
            var serializer = new XmlSerializer(typeof(Sleepers));

            serializer.Serialize(writer, sleepers, namespaces);

            string xml = writer.ToString();

            validate(xml);

            Assert.Equal("", validationOutput);

        }
        [Fact]

        public void DangerPoint()

        {

            namespaces.Add("infra", "https://erju.org/infra");

            DangerPoint dangerPoint = new DangerPoint();
            dangerPoint.Id = "HelloWorld";
            dangerPoint.Name = "HelloWorld";
            dangerPoint.TrackEdge = "HelloWorld";
            dangerPoint.pos = 4294967295;
            var serializer = new XmlSerializer(typeof(DangerPoint));

            serializer.Serialize(writer, dangerPoint, namespaces);

            string xml = writer.ToString();

            validate(xml);

            Assert.Equal("", validationOutput);

        }
        [Fact]

        public void MileagePoint()

        {

            namespaces.Add("infra", "https://erju.org/infra");

            MileagePoint mileagePoint = new MileagePoint();
            mileagePoint.pos = 1.0;
            mileagePoint.mileage = 1.0;
            var serializer = new XmlSerializer(typeof(MileagePoint));

            serializer.Serialize(writer, mileagePoint, namespaces);

            string xml = writer.ToString();

            validate(xml);

            Assert.Equal("", validationOutput);

        }
        [Fact]

        public void TrackEdgeMileage()

        {

            namespaces.Add("infra", "https://erju.org/infra");

            TrackEdgeMileage trackEdgeMileage = new TrackEdgeMileage();
            trackEdgeMileage.Id = "HelloWorld";
            trackEdgeMileage.points = new() { new() };
            var serializer = new XmlSerializer(typeof(TrackEdgeMileage));

            serializer.Serialize(writer, trackEdgeMileage, namespaces);

            string xml = writer.ToString();

            validate(xml);

            Assert.Equal("", validationOutput);

        }
        [Fact]

        public void MileageReferenceMarker()

        {

            namespaces.Add("infra", "https://erju.org/infra");

            MileageReferenceMarker mileageReferenceMarker = new MileageReferenceMarker();
            mileageReferenceMarker.Name = "HelloWorld";
            mileageReferenceMarker.mileage = 1.0;
            mileageReferenceMarker.TrackEdge = "HelloWorld";
            mileageReferenceMarker.pos = 1.0;
            var serializer = new XmlSerializer(typeof(MileageReferenceMarker));

            serializer.Serialize(writer, mileageReferenceMarker, namespaces);

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
            mileageLine.trackEdges = new() { new() };
            mileageLine.horizontalGeometry = new() { new() {arc=new() } };
            mileageLine.referenceMarkers = new() { new()};
            var serializer = new XmlSerializer(typeof(MileageLine));

            serializer.Serialize(writer, mileageLine, namespaces);

            string xml = writer.ToString();

            validate(xml);

            Assert.Equal("", validationOutput);

        }
        [Fact]

        public void MileageArea()

        {

            namespaces.Add("infra", "https://erju.org/infra");

            MileageArea mileageArea = new MileageArea();
            mileageArea.Id = "HelloWorld";
            mileageArea.mileageLines = new() { new() };
            var serializer = new XmlSerializer(typeof(MileageArea));

            serializer.Serialize(writer, mileageArea, namespaces);

            string xml = writer.ToString();

            validate(xml);

            Assert.Equal("", validationOutput);

        }
        [Fact]

        public void EngArea()

        {

            namespaces.Add("infra", "https://erju.org/infra");

            EngArea engArea = new EngArea();
            engArea.Id = "HelloWorld";
            engArea.defaultSleelersType = SleepersType.unknownSleepersType;
            engArea.simplePoints = new() { new() };
            engArea.crossings = new() { new() };
            engArea.levelCrossings = new() { new() };
            engArea.baliseGroup = new() { new() };
            engArea.balises = new() { new() };
            engArea.sleepers = new() { new() };
            engArea.dangerPoints = new() { new() };
            engArea.bufferStops = new() { new() };
            engArea.mileageAreas = new() { new() };
            var serializer = new XmlSerializer(typeof(EngArea));

            serializer.Serialize(writer, engArea, namespaces);

            string xml = writer.ToString();

            validate(xml);

            Assert.Equal("", validationOutput);

        }
        [Fact]

        public void ETCSEngineering()

        {

            namespaces.Add("infra", "https://erju.org/infra");

            ETCSEngineering eTCSEngineering = new ETCSEngineering();
            eTCSEngineering.areas = new() { new() };
            eTCSEngineering.mileageAreas = new() { new() };
            var serializer = new XmlSerializer(typeof(ETCSEngineering));

            serializer.Serialize(writer, eTCSEngineering, namespaces);

            string xml = writer.ToString();

            validate(xml);

            Assert.Equal("", validationOutput);

        }

    }
}