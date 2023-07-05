using eng;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;
using System.Xml.Schema;
using System.Xml.Serialization;

namespace Test
{
    public class ERJUengFilled
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
                validationOutput += e.Message;
            }
            else if (e.Severity == XmlSeverityType.Error)
            {
                validationOutput += e.Message;
            }
        }

        [Fact]
        public void BufferStop()
        {
            namespaces.Add("eng", "https://erju.org/eng");

            BufferStop bufferStop = new BufferStop();

            bufferStop.Id = "HelloWorld";
            bufferStop.dangerPoints = new() { new()};
            bufferStop.trackEdgeSections = new();
            bufferStop.bsType = new();
            var serializer = new XmlSerializer(typeof(BufferStop));

            serializer.Serialize(writer, bufferStop, namespaces);

            // Get the serialized XML as a string
            string xml = writer.ToString();

            validate(xml);

            Assert.Equal("", validationOutput);
        }
        [Fact]
        public void SimplePoint()
        {
            namespaces.Add("eng", "https://erju.org/eng");

            SimplePoint simplePoint = new SimplePoint();

            simplePoint.Id = "HelloWorld";
            simplePoint.dangerPoints = new() { new()};
            var serializer = new XmlSerializer(typeof(SimplePoint));

            serializer.Serialize(writer, simplePoint, namespaces);

            // Get the serialized XML as a string
            string xml = writer.ToString();

            validate(xml);

            Assert.Equal("", validationOutput);
        }
        [Fact]
        public void Crossing()
        {
            namespaces.Add("eng", "https://erju.org/eng");

            Crossing crossing = new Crossing();

            crossing.Id = "HelloWorld";
            crossing.dangerPoints = new() {new()};
            var serializer = new XmlSerializer(typeof(Crossing));

            serializer.Serialize(writer, crossing, namespaces);

            // Get the serialized XML as a string
            string xml = writer.ToString();

            validate(xml);

            Assert.Equal("", validationOutput);
        }
        [Fact]
        public void LevelCrossing()
        {
            namespaces.Add("eng", "https://erju.org/eng");

            LevelCrossing levelCrossing = new LevelCrossing();

            levelCrossing.Id = "HelloWorld";
            levelCrossing.dangerPoints = new() { new () };
            var serializer = new XmlSerializer(typeof(LevelCrossing));

            serializer.Serialize(writer, levelCrossing, namespaces);

            // Get the serialized XML as a string
            string xml = writer.ToString();

            validate(xml);

            Assert.Equal("", validationOutput);
        }
        [Fact]
        public void BalisePacket()
        {
            namespaces.Add("eng", "https://erju.org/eng");

            BalisePacket balisePacket = new BalisePacket();

            balisePacket.nid = 4294967295;
            balisePacket.Packet = new byte[] {};
            var serializer = new XmlSerializer(typeof(BalisePacket));

            serializer.Serialize(writer, balisePacket, namespaces);

            // Get the serialized XML as a string
            string xml = writer.ToString();

            validate(xml);

            Assert.Equal("", validationOutput);
        }
        [Fact]
        public void Balise()
        {
            namespaces.Add("eng", "https://erju.org/eng");

            Balise balise = new Balise();

            balise.Id = "HelloWorld";
            balise._fixed = true;
            balise.linked = true;
            balise.verticallyOriented = true;
            balise.standardSize = true;
            balise.etcsPackets = new();
            var serializer = new XmlSerializer(typeof(Balise));

            serializer.Serialize(writer, balise, namespaces);

            // Get the serialized XML as a string
            string xml = writer.ToString();

            validate(xml);

            Assert.Equal("", validationOutput);
        }
        [Fact]
        public void Sleepers()
        {
            namespaces.Add("eng", "https://erju.org/eng");

            Sleepers sleepers = new Sleepers();

            sleepers.Id = "HelloWorld";
            sleepers.trackEdgeSection = new();
            sleepers.type = new();
            var serializer = new XmlSerializer(typeof(Sleepers));

            serializer.Serialize(writer, sleepers, namespaces);

            // Get the serialized XML as a string
            string xml = writer.ToString();

            validate(xml);

            Assert.Equal("", validationOutput);
        }
        [Fact]
        public void DangerPoint()
        {
            namespaces.Add("eng", "https://erju.org/eng");

            DangerPoint dangerPoint = new DangerPoint();

            dangerPoint.Id = "HelloWorld";
            dangerPoint.Name = "HelloWorld";
            dangerPoint.trackEdgePoint = new();
            var serializer = new XmlSerializer(typeof(DangerPoint));

            serializer.Serialize(writer, dangerPoint, namespaces);

            // Get the serialized XML as a string
            string xml = writer.ToString();

            validate(xml);

            Assert.Equal("", validationOutput);
        }
        [Fact]
        public void EngArea()
        {
            namespaces.Add("eng", "https://erju.org/eng");

            EngArea engArea = new EngArea();

            engArea.Id = "HelloWorld";
            engArea.defaultSpeelersType = new();
            engArea.simplePoints = new();
            engArea.crossings = new();
            engArea.levelCrossings = new();
            engArea.balises = new();
            engArea.sleepers = new();
            engArea.dangerPoints = new();
            engArea.bufferStops = new();
            var serializer = new XmlSerializer(typeof(EngArea));

            serializer.Serialize(writer, engArea, namespaces);

            // Get the serialized XML as a string
            string xml = writer.ToString();

            validate(xml);

            Assert.Equal("", validationOutput);
        }
        [Fact]
        public void ETCSEngineering()
        {
            namespaces.Add("eng", "https://erju.org/eng");

            ETCSEngineering eTCSEngineering = new ETCSEngineering();

            eTCSEngineering.areas = new();
            var serializer = new XmlSerializer(typeof(ETCSEngineering));

            serializer.Serialize(writer, eTCSEngineering, namespaces);

            // Get the serialized XML as a string
            string xml = writer.ToString();

            validate(xml);

            Assert.Equal("", validationOutput);
        }

    }
}
