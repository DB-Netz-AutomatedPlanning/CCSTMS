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
    public class ERJUeng
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
        public void SimplePoint()
        {

            namespaces.Add("eng", "https://erju.org/eng");



            SimplePoint simplePoint = new SimplePoint();

            var serializer = new XmlSerializer(typeof(SimplePoint));



            serializer.Serialize(writer, simplePoint, namespaces);



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

            var serializer = new XmlSerializer(typeof(Balise));



            serializer.Serialize(writer, balise, namespaces);



            // Get the serialized XML as a string

            string xml = writer.ToString();



            validate(xml);



            Assert.Equal("", validationOutput);

        }
    }
}
