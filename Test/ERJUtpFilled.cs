using System.Xml.Schema;
using System.Xml;
using System.Xml.Serialization;
using System.Security.Cryptography.X509Certificates;
using ato;
using tp;

namespace Test
{
    
    public class ERJUtpFilled
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
        public void ProtectedInfraElement()
        {
            namespaces.Add("tp", "https://erju.org/tp");

            ProtectedInfraElement protectedInfraElement = new ProtectedInfraElement();

            protectedInfraElement.SimplePoint = "";
            protectedInfraElement.Crossing = "";
            protectedInfraElement.Derailer = "";
            protectedInfraElement.LevelCrossing = "";
            var serializer = new XmlSerializer(typeof(ProtectedInfraElement));

            serializer.Serialize(writer, protectedInfraElement, namespaces);

            // Get the serialized XML as a string
            string xml = writer.ToString();

            validate(xml);

            Assert.Equal("", validationOutput);
        }
        [Fact]
        public void DriveProtectionSectionGroup()
        {
            namespaces.Add("tp", "https://erju.org/tp");

            DriveProtectionSectionGroup driveProtectionSectionGroup = new DriveProtectionSectionGroup();

            driveProtectionSectionGroup.Id = "HelloWorld";
            driveProtectionSectionGroup.Name = "HelloWorld";
            driveProtectionSectionGroup.driveProtectionSections = new();
            driveProtectionSectionGroup.protectedInfraElements = new();
            var serializer = new XmlSerializer(typeof(DriveProtectionSectionGroup));

            serializer.Serialize(writer, driveProtectionSectionGroup, namespaces);

            // Get the serialized XML as a string
            string xml = writer.ToString();

            validate(xml);

            Assert.Equal("", validationOutput);
        }
        [Fact]
        public void DriveProtectionSection()
        {
            namespaces.Add("tp", "https://erju.org/tp");

            DriveProtectionSection driveProtectionSection = new DriveProtectionSection();

            driveProtectionSection.Id = "HelloWorld";
            driveProtectionSection.Name = "HelloWorld";
            driveProtectionSection.trackEdgeSection = new();
            driveProtectionSection.flankProtectionDirection = new();
            driveProtectionSection.minimalDrivability = new();
            var serializer = new XmlSerializer(typeof(DriveProtectionSection));

            serializer.Serialize(writer, driveProtectionSection, namespaces);

            // Get the serialized XML as a string
            string xml = writer.ToString();

            validate(xml);

            Assert.Equal("", validationOutput);
        }
        [Fact]
        public void AllocationSection()
        {
            namespaces.Add("tp", "https://erju.org/tp");

            AllocationSection allocationSection = new AllocationSection();

            allocationSection.Id = "HelloWorld";
            allocationSection.Name = "HelloWorld";
            allocationSection.linearLocation = new();
            allocationSection.allocationSections = new() {new()};
            allocationSection.allocatedInfraElement = new();
            var serializer = new XmlSerializer(typeof(AllocationSection));

            serializer.Serialize(writer, allocationSection, namespaces);

            // Get the serialized XML as a string
            string xml = writer.ToString();

            validate(xml);

            Assert.Equal("", validationOutput);
        }
        [Fact]
        public void TrainProtectionArea()
        {
            namespaces.Add("tp", "https://erju.org/tp");

            TrainProtectionArea trainProtectionArea = new TrainProtectionArea();

            trainProtectionArea.dpsGroups = new();
            trainProtectionArea.allocationSections = new();
            var serializer = new XmlSerializer(typeof(TrainProtectionArea));

            serializer.Serialize(writer, trainProtectionArea, namespaces);

            // Get the serialized XML as a string
            string xml = writer.ToString();

            validate(xml);

            Assert.Equal("", validationOutput);
        }
        [Fact]
        public void TrainProtection()
        {
            namespaces.Add("tp", "https://erju.org/tp");

            TrainProtection trainProtection = new TrainProtection();

            trainProtection.tpArea = new();
            var serializer = new XmlSerializer(typeof(TrainProtection));

            serializer.Serialize(writer, trainProtection, namespaces);

            // Get the serialized XML as a string
            string xml = writer.ToString();

            validate(xml);

            Assert.Equal("", validationOutput);
        }


    }
}