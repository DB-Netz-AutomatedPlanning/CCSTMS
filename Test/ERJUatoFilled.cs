using System.Xml.Schema;
using System.Xml;
using System.Xml.Serialization;
using System.Security.Cryptography.X509Certificates;
using tp;
using ato;

namespace Test
{ 
    public class ERJUatoFilled
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
        public void ATO()
        {
            namespaces.Add("ato", "https://erju.org/ato");

            ATO aTO = new ATO();

            aTO.atoAreas = new();
            var serializer = new XmlSerializer(typeof(ATO));

            serializer.Serialize(writer, aTO, namespaces);

            // Get the serialized XML as a string
            string xml = writer.ToString();

            validate(xml);

            Assert.Equal("", validationOutput);
        }
        [Fact]
        public void ATOArea()
        {
            namespaces.Add("ato", "https://erju.org/ato");

            ATOArea aTOArea = new ATOArea();

            aTOArea.AtoTSId = "HelloWorld";
            aTOArea.segments = new();
            var serializer = new XmlSerializer(typeof(ATOArea));

            serializer.Serialize(writer, aTOArea, namespaces);

            // Get the serialized XML as a string
            string xml = writer.ToString();

            validate(xml);

            Assert.Equal("", validationOutput);
        }
        [Fact]
        public void ATOSegment()
        {
            namespaces.Add("ato", "https://erju.org/ato");

            ATOSegment aTOSegment = new ATOSegment();

            aTOSegment.id = 4294967295;
            aTOSegment.sameDir = true;
            aTOSegment.trackSection = new();
            aTOSegment.segmentProfile = new();
            aTOSegment.segmentProfile.atotsContactInfo = new();
            aTOSegment.segmentProfile.staticSpeedProfileStart = new();
            aTOSegment.segmentProfile.staticSpeedProfileChanges = new();
            aTOSegment.segmentProfile.specificStaticSpeedProfileStart = new();
            aTOSegment.segmentProfile.specificStaticSpeedProfileChanges = new();
            aTOSegment.segmentProfile.gradientStart = new();
            aTOSegment.segmentProfile.gradientChanges = new();
            aTOSegment.segmentProfile.curveStart = new();
            aTOSegment.segmentProfile.curveChanges = new();
            aTOSegment.segmentProfile.voltageStart = new();
            aTOSegment.segmentProfile.voltageChanges = new();
            aTOSegment.segmentProfile.currentStart = new();
            aTOSegment.segmentProfile.currentChanges = new();
            aTOSegment.segmentProfile.baliseGroups = new();
            aTOSegment.segmentProfile.timingPoints = new();
            aTOSegment.segmentProfile.platformAreas = new();
            aTOSegment.segmentProfile.tunnels = new();
            aTOSegment.segmentProfile.axleLoadSpeedProfiles = new();
            aTOSegment.segmentProfile.unprotectedLXs = new();
            aTOSegment.segmentProfile.permittedBrakingDistances = new();
            aTOSegment.segmentProfile.switchOffEddyCurrentBrakeServiceBrakes = new();
            aTOSegment.segmentProfile.switchOffEddyCurrentBrakeEmergencyBrakes = new();
            aTOSegment.segmentProfile.switchOffRegenerativeBrakes = new();
            aTOSegment.segmentProfile.switchOffMagneticShoeBrakes = new();
            aTOSegment.segmentProfile.dynamicBrakeForceInhibitions = new();
            aTOSegment.segmentProfile.limitedDynamicBrakeForces = new();
            var serializer = new XmlSerializer(typeof(ATOSegment));

            serializer.Serialize(writer, aTOSegment, namespaces);

            // Get the serialized XML as a string
            string xml = writer.ToString();

            validate(xml);

            Assert.Equal("", validationOutput);
        }
        [Fact]
        public void SegmentProfile()
        {
            namespaces.Add("ato", "https://erju.org/ato");

            SegmentProfile segmentProfile = new SegmentProfile();

            segmentProfile.nidSP = 4294967295;
            segmentProfile.length = 4294967295;
            segmentProfile.version = 4294967295;
            segmentProfile.nidC = 4294967295;
            segmentProfile.eoaOffset = 4294967295;
            segmentProfile.utcOffset = 4294967295;
            segmentProfile.startAltitude = 4294967295;
            segmentProfile.atotsContactInfoDir = true;
            segmentProfile.atotsContactInfo = new();
            segmentProfile.staticSpeedProfileStart = new();
            segmentProfile.staticSpeedProfileChanges = new();
            segmentProfile.specificStaticSpeedProfileStart = new();
            segmentProfile.specificStaticSpeedProfileChanges = new();
            segmentProfile.gradientStart = new();
            segmentProfile.gradientChanges = new();
            segmentProfile.curveStart = new();
            segmentProfile.curveChanges = new();
            segmentProfile.voltageStart = new();
            segmentProfile.voltageChanges = new();
            segmentProfile.currentStart = new();
            segmentProfile.currentChanges = new();
            segmentProfile.baliseGroups = new();
            segmentProfile.timingPoints = new();
            segmentProfile.platformAreas = new();
            segmentProfile.tunnels = new();
            segmentProfile.axleLoadSpeedProfiles = new();
            segmentProfile.unprotectedLXs = new();
            segmentProfile.permittedBrakingDistances = new();
            segmentProfile.switchOffEddyCurrentBrakeServiceBrakes = new();
            segmentProfile.switchOffEddyCurrentBrakeEmergencyBrakes = new();
            segmentProfile.switchOffRegenerativeBrakes = new();
            segmentProfile.switchOffMagneticShoeBrakes = new();
            segmentProfile.dynamicBrakeForceInhibitions = new();
            segmentProfile.limitedDynamicBrakeForces = new();
            var serializer = new XmlSerializer(typeof(SegmentProfile));

            serializer.Serialize(writer, segmentProfile, namespaces);

            // Get the serialized XML as a string
            string xml = writer.ToString();

            validate(xml);

            Assert.Equal("", validationOutput);
        }
        [Fact]
        public void AtoTSContactInfo()
        {
            namespaces.Add("ato", "https://erju.org/ato");

            AtoTSContactInfo atoTSContactInfo = new AtoTSContactInfo();

            atoTSContactInfo.nidATOTS = 4294967295;
            atoTSContactInfo.nidSP = 4294967295;
            atoTSContactInfo.spNidC = 4294967295;
            atoTSContactInfo.atotsNidC = 4294967295;
            var serializer = new XmlSerializer(typeof(AtoTSContactInfo));

            serializer.Serialize(writer, atoTSContactInfo, namespaces);

            // Get the serialized XML as a string
            string xml = writer.ToString();

            validate(xml);

            Assert.Equal("", validationOutput);
        }
        [Fact]
        public void StaticSpeedProfileStart()
        {
            namespaces.Add("ato", "https://erju.org/ato");

            StaticSpeedProfileStart staticSpeedProfileStart = new StaticSpeedProfileStart();

            staticSpeedProfileStart.specificStaticSpeedProfile = new();
            staticSpeedProfileStart.speed = 4294967295;
            staticSpeedProfileStart.trainEndApplicability = new();
            var serializer = new XmlSerializer(typeof(StaticSpeedProfileStart));

            serializer.Serialize(writer, staticSpeedProfileStart, namespaces);

            // Get the serialized XML as a string
            string xml = writer.ToString();

            validate(xml);

            Assert.Equal("", validationOutput);
        }
        [Fact]
        public void SpecificStaticSpeedProfileStart()
        {
            namespaces.Add("ato", "https://erju.org/ato");

            SpecificStaticSpeedProfileStart specificStaticSpeedProfileStart = new SpecificStaticSpeedProfileStart();

            specificStaticSpeedProfileStart.speed = 4294967295;
            specificStaticSpeedProfileStart.specificStaticSpeedProfileType = new();
            specificStaticSpeedProfileStart.otherSpecificStaticSpeedProfileCategory = new();
            specificStaticSpeedProfileStart.cantDeficiencyCategory = new();
            var serializer = new XmlSerializer(typeof(SpecificStaticSpeedProfileStart));

            serializer.Serialize(writer, specificStaticSpeedProfileStart, namespaces);

            // Get the serialized XML as a string
            string xml = writer.ToString();

            validate(xml);

            Assert.Equal("", validationOutput);
        }
        [Fact]
        public void StaticSpeedProfileChange()
        {
            namespaces.Add("ato", "https://erju.org/ato");

            StaticSpeedProfileChange staticSpeedProfileChange = new StaticSpeedProfileChange();

            staticSpeedProfileChange.p = 4294967295;
            staticSpeedProfileChange.specificStaticSpeedProfile = new();
            staticSpeedProfileChange.speed = 4294967295;
            staticSpeedProfileChange.trainEndApplicability = new();
            var serializer = new XmlSerializer(typeof(StaticSpeedProfileChange));

            serializer.Serialize(writer, staticSpeedProfileChange, namespaces);

            // Get the serialized XML as a string
            string xml = writer.ToString();

            validate(xml);

            Assert.Equal("", validationOutput);
        }
        [Fact]
        public void SpecificStaticSpeedProfileChange()
        {
            namespaces.Add("ato", "https://erju.org/ato");

            SpecificStaticSpeedProfileChange specificStaticSpeedProfileChange = new SpecificStaticSpeedProfileChange();

            specificStaticSpeedProfileChange.speed = 4294967295;
            specificStaticSpeedProfileChange.specificStaticSpeedProfileType = new();
            specificStaticSpeedProfileChange.otherSpecificStaticSpeedProfileCategory = new();
            specificStaticSpeedProfileChange.cantDeficiencyCategory = new();
            var serializer = new XmlSerializer(typeof(SpecificStaticSpeedProfileChange));

            serializer.Serialize(writer, specificStaticSpeedProfileChange, namespaces);

            // Get the serialized XML as a string
            string xml = writer.ToString();

            validate(xml);

            Assert.Equal("", validationOutput);
        }
        [Fact]
        public void AxleLoadSpeedProfile()
        {
            namespaces.Add("ato", "https://erju.org/ato");

            AxleLoadSpeedProfile axleLoadSpeedProfile = new AxleLoadSpeedProfile();

            axleLoadSpeedProfile.segmentSection = new();
            axleLoadSpeedProfile.speed = 4294967295;
            axleLoadSpeedProfile.trainEndApplicability = new();
            axleLoadSpeedProfile.axleLoadCategory = new();
            var serializer = new XmlSerializer(typeof(AxleLoadSpeedProfile));

            serializer.Serialize(writer, axleLoadSpeedProfile, namespaces);

            // Get the serialized XML as a string
            string xml = writer.ToString();

            validate(xml);

            Assert.Equal("", validationOutput);
        }
        [Fact]
        public void GradientStart()
        {
            namespaces.Add("ato", "https://erju.org/ato");

            GradientStart gradientStart = new GradientStart();

            gradientStart.gradient = 4294967295;
            gradientStart.uphillGradient = true;
            var serializer = new XmlSerializer(typeof(GradientStart));

            serializer.Serialize(writer, gradientStart, namespaces);

            // Get the serialized XML as a string
            string xml = writer.ToString();

            validate(xml);

            Assert.Equal("", validationOutput);
        }
        [Fact]
        public void GradientChange()
        {
            namespaces.Add("ato", "https://erju.org/ato");

            GradientChange gradientChange = new GradientChange();

            gradientChange.p = 4294967295;
            gradientChange.uphillGradient = true;
            var serializer = new XmlSerializer(typeof(GradientChange));

            serializer.Serialize(writer, gradientChange, namespaces);

            // Get the serialized XML as a string
            string xml = writer.ToString();

            validate(xml);

            Assert.Equal("", validationOutput);
        }
        [Fact]
        public void CurveStart()
        {
            namespaces.Add("ato", "https://erju.org/ato");

            CurveStart curveStart = new CurveStart();

            curveStart.curve = new();
            var serializer = new XmlSerializer(typeof(CurveStart));

            serializer.Serialize(writer, curveStart, namespaces);

            // Get the serialized XML as a string
            string xml = writer.ToString();

            validate(xml);

            Assert.Equal("", validationOutput);
        }
        [Fact]
        public void CurveChange()
        {
            namespaces.Add("ato", "https://erju.org/ato");

            CurveChange curveChange = new CurveChange();

            curveChange.curve = new();
            curveChange.p = 4294967295;
            var serializer = new XmlSerializer(typeof(CurveChange));

            serializer.Serialize(writer, curveChange, namespaces);

            // Get the serialized XML as a string
            string xml = writer.ToString();

            validate(xml);

            Assert.Equal("", validationOutput);
        }
        [Fact]
        public void TimingPoint()
        {
            namespaces.Add("ato", "https://erju.org/ato");

            TimingPoint timingPoint = new TimingPoint();

            timingPoint.Name = "HelloWorld";
            timingPoint.p = 4294967295;
            timingPoint.nidTP = 4294967295;
            timingPoint.stopLocationTolerance = 4294967295;
            timingPoint.stoppingPointReachDistance = 4294967295;
            var serializer = new XmlSerializer(typeof(TimingPoint));

            serializer.Serialize(writer, timingPoint, namespaces);

            // Get the serialized XML as a string
            string xml = writer.ToString();

            validate(xml);

            Assert.Equal("", validationOutput);
        }
        [Fact]
        public void BaliseGroup()
        {
            namespaces.Add("ato", "https://erju.org/ato");

            BaliseGroup baliseGroup = new BaliseGroup();

            baliseGroup.nidBG = 4294967295;
            baliseGroup.balises = new();
            baliseGroup.nidCQualifier = true;
            baliseGroup.nidC = 4294967295;
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
            namespaces.Add("ato", "https://erju.org/ato");

            Balise balise = new Balise();

            balise.positionInGroup = 4294967295;
            balise.p = 4294967295;
            var serializer = new XmlSerializer(typeof(Balise));

            serializer.Serialize(writer, balise, namespaces);

            // Get the serialized XML as a string
            string xml = writer.ToString();

            validate(xml);

            Assert.Equal("", validationOutput);
        }
        [Fact]
        public void PermittedBrakingDistance()
        {
            namespaces.Add("ato", "https://erju.org/ato");

            PermittedBrakingDistance permittedBrakingDistance = new PermittedBrakingDistance();

            permittedBrakingDistance.segmentSection = new();
            permittedBrakingDistance.value = 4294967295;
            permittedBrakingDistance.byEmergencyBrake = true;
            permittedBrakingDistance.gradient = 4294967295;
            permittedBrakingDistance.uphillGradient = true;
            var serializer = new XmlSerializer(typeof(PermittedBrakingDistance));

            serializer.Serialize(writer, permittedBrakingDistance, namespaces);

            // Get the serialized XML as a string
            string xml = writer.ToString();

            validate(xml);

            Assert.Equal("", validationOutput);
        }
        [Fact]
        public void VoltageStart()
        {
            namespaces.Add("ato", "https://erju.org/ato");

            VoltageStart voltageStart = new VoltageStart();

            voltageStart.voltage = new();
            voltageStart.nidC = 4294967295;
            var serializer = new XmlSerializer(typeof(VoltageStart));

            serializer.Serialize(writer, voltageStart, namespaces);

            // Get the serialized XML as a string
            string xml = writer.ToString();

            validate(xml);

            Assert.Equal("", validationOutput);
        }
        [Fact]
        public void VoltageChange()
        {
            namespaces.Add("ato", "https://erju.org/ato");

            VoltageChange voltageChange = new VoltageChange();

            voltageChange.p = 4294967295;
            voltageChange.voltage = new();
            voltageChange.nidC = 4294967295;
            var serializer = new XmlSerializer(typeof(VoltageChange));

            serializer.Serialize(writer, voltageChange, namespaces);

            // Get the serialized XML as a string
            string xml = writer.ToString();

            validate(xml);

            Assert.Equal("", validationOutput);
        }
        [Fact]
        public void CurrentStart()
        {
            namespaces.Add("ato", "https://erju.org/ato");

            CurrentStart currentStart = new CurrentStart();

            currentStart.current = 4294967295;
            var serializer = new XmlSerializer(typeof(CurrentStart));

            serializer.Serialize(writer, currentStart, namespaces);

            // Get the serialized XML as a string
            string xml = writer.ToString();

            validate(xml);

            Assert.Equal("", validationOutput);
        }
        [Fact]
        public void CurrentChange()
        {
            namespaces.Add("ato", "https://erju.org/ato");

            CurrentChange currentChange = new CurrentChange();

            currentChange.p = 4294967295;
            currentChange.current = 4294967295;
            var serializer = new XmlSerializer(typeof(CurrentChange));

            serializer.Serialize(writer, currentChange, namespaces);

            // Get the serialized XML as a string
            string xml = writer.ToString();

            validate(xml);

            Assert.Equal("", validationOutput);
        }
        [Fact]
        public void Tunnel()
        {
            namespaces.Add("ato", "https://erju.org/ato");

            Tunnel tunnel = new Tunnel();

            tunnel.segmentSection = new();
            tunnel.type = new();
            var serializer = new XmlSerializer(typeof(Tunnel));

            serializer.Serialize(writer, tunnel, namespaces);

            // Get the serialized XML as a string
            string xml = writer.ToString();

            validate(xml);

            Assert.Equal("", validationOutput);
        }
        [Fact]
        public void UnprotectedLX()
        {
            namespaces.Add("ato", "https://erju.org/ato");

            UnprotectedLX unprotectedLX = new UnprotectedLX();

            unprotectedLX.pNominal = 4294967295;
            unprotectedLX.pReverse = 4294967295;
            var serializer = new XmlSerializer(typeof(UnprotectedLX));

            serializer.Serialize(writer, unprotectedLX, namespaces);

            // Get the serialized XML as a string
            string xml = writer.ToString();

            validate(xml);

            Assert.Equal("", validationOutput);
        }
        [Fact]
        public void LimitedDynamicBrakeForce()
        {
            namespaces.Add("ato", "https://erju.org/ato");

            LimitedDynamicBrakeForce limitedDynamicBrakeForce = new LimitedDynamicBrakeForce();

            limitedDynamicBrakeForce.segmentSection = new();
            limitedDynamicBrakeForce.dynamicBrakeForceLimit = 4294967295;
            var serializer = new XmlSerializer(typeof(LimitedDynamicBrakeForce));

            serializer.Serialize(writer, limitedDynamicBrakeForce, namespaces);

            // Get the serialized XML as a string
            string xml = writer.ToString();

            validate(xml);

            Assert.Equal("", validationOutput);
        }
        [Fact]
        public void SegmentSection()
        {
            namespaces.Add("ato", "https://erju.org/ato");

            SegmentSection segmentSection = new SegmentSection();

            segmentSection.range = new();
            segmentSection.pStart = 4294967295;
            segmentSection.pEnd = 4294967295;
            var serializer = new XmlSerializer(typeof(SegmentSection));

            serializer.Serialize(writer, segmentSection, namespaces);

            // Get the serialized XML as a string
            string xml = writer.ToString();

            validate(xml);

            Assert.Equal("", validationOutput);
        }
    }
}