using System.Xml.Schema;
using System.Xml;
using System.Xml.Serialization;
using ss026;
using System.Security.Cryptography.X509Certificates;


namespace Test
{
    
    public class SS026Filled
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

        public void BalisePacket()

        {
            BalisePacket balisePacket = new BalisePacket();
            balisePacket.nid = 4294967295;
            balisePacket.q_dir = QDir.reverse;
            balisePacket.packet = new() {packet_0=new() };
            var serializer = new XmlSerializer(typeof(BalisePacket));

            serializer.Serialize(writer, balisePacket, namespaces);

            string xml = writer.ToString();

            validate(xml);

            Assert.Equal("", validationOutput);

        }
        [Fact]

        public void Packet()

        {
            Packet packet = new Packet();
            packet.packet_0 = new();
            var serializer = new XmlSerializer(typeof(Packet));

            serializer.Serialize(writer, packet, namespaces);

            string xml = writer.ToString();

            validate(xml);

            Assert.Equal("", validationOutput);

        }
        [Fact]

        public void ETCSPacket_0()

        {

            

            ETCSPacket_0 eTCSPacket_0 = new ETCSPacket_0();
            eTCSPacket_0.nid_vbcmk = 4294967295;
            var serializer = new XmlSerializer(typeof(ETCSPacket_0));

            serializer.Serialize(writer, eTCSPacket_0, namespaces);

            string xml = writer.ToString();

            validate(xml);

            Assert.Equal("", validationOutput);

        }
        [Fact]

        public void ETCSPacket_2()

        {

            

            ETCSPacket_2 eTCSPacket_2 = new ETCSPacket_2();
            eTCSPacket_2.m_version = ETCSVersion.v1_0;
            var serializer = new XmlSerializer(typeof(ETCSPacket_2));

            serializer.Serialize(writer, eTCSPacket_2, namespaces);

            string xml = writer.ToString();

            validate(xml);

            Assert.Equal("", validationOutput);

        }
        [Fact]

        public void LMKVR()

        {

            

            LMKVR lMKVR = new LMKVR();
            lMKVR.l_nvkrint_l = 4294967295;
            lMKVR.m_nvkrint_l = 4294967295;
            var serializer = new XmlSerializer(typeof(LMKVR));

            serializer.Serialize(writer, lMKVR, namespaces);

            string xml = writer.ToString();

            validate(xml);

            Assert.Equal("", validationOutput);

        }
        [Fact]

        public void NKV()

        {

            

            NKV nKV = new NKV();
            nKV.q_nvkint = true;
            nKV.q_nvkvintset = KVType.freightTrains;
            nKV.a_nvp12 = 4294967295;
            nKV.a_nvp23 = 4294967295;
            nKV.v_nvkvint = 4294967295;
            nKV.m_nvkvint = 1.0;
            nKV.m_nvkvint_2 = 4294967295;
            nKV.items = new() { new() };
            nKV.qvItem = new() { new() };
            nKV.lmkvrs = new() { new() };
            nKV.m_nvkrint = 4294967295;
            var serializer = new XmlSerializer(typeof(NKV));

            serializer.Serialize(writer, nKV, namespaces);

            string xml = writer.ToString();

            validate(xml);

            Assert.Equal("", validationOutput);

        }
        [Fact]

        public void NVP13()

        {

            

            NVP13 nVP13 = new NVP13();
            nVP13.a_nvp12 = 4294967295;
            nVP13.a_nvp23 = 4294967295;
            var serializer = new XmlSerializer(typeof(NVP13));

            serializer.Serialize(writer, nVP13, namespaces);

            string xml = writer.ToString();

            validate(xml);

            Assert.Equal("", validationOutput);

        }
        [Fact]

        public void VMM()

        {

            

            VMM vMM = new VMM();
            vMM.v_nvkvint_k_m = 4294967295;
            vMM.m_nvkvint_k_m = 4294967295;
            vMM.m_nvkvint_k_m_2 = 4294967295;
            var serializer = new XmlSerializer(typeof(VMM));

            serializer.Serialize(writer, vMM, namespaces);

            string xml = writer.ToString();

            validate(xml);

            Assert.Equal("", validationOutput);

        }
        [Fact]

        public void NKVSubItem()

        {

            

            NKVSubItem nKVSubItem = new NKVSubItem();
            nKVSubItem.nvp13 = new() {a_nvp12=1 };
            nKVSubItem.mvvs = new() { new() };
            var serializer = new XmlSerializer(typeof(NKVSubItem));

            serializer.Serialize(writer, nKVSubItem, namespaces);

            string xml = writer.ToString();

            validate(xml);

            Assert.Equal("", validationOutput);

        }
        [Fact]

        public void NKVItem()

        {

            

            NKVItem nKVItem = new NKVItem();
            nKVItem.v_nvkvint = 4294967295;
            nKVItem.m_nvkvint = 4294967295;
            var serializer = new XmlSerializer(typeof(NKVItem));

            serializer.Serialize(writer, nKVItem, namespaces);

            string xml = writer.ToString();

            validate(xml);

            Assert.Equal("", validationOutput);

        }
        [Fact]

        public void ETCSPacket_3()

        {

            

            ETCSPacket_3 eTCSPacket_3 = new ETCSPacket_3();
            eTCSPacket_3.d_validnv = 4294967295;
            eTCSPacket_3.nid_c = 4294967295;
            eTCSPacket_3.nid_c_k = 4294967295;
            eTCSPacket_3.v_nvshunt = 4294967295;
            eTCSPacket_3.v_nvstff = 4294967295;
            eTCSPacket_3.v_nvonsight = 4294967295;
            eTCSPacket_3.v_nvlimsuperv = 4294967295;
            eTCSPacket_3.v_nvunfit = 4294967295;
            eTCSPacket_3.v_nvrel = 4294967295;
            eTCSPacket_3.d_nvroll = 4294967295;
            eTCSPacket_3.q_nvsbtsmperm = true;
            eTCSPacket_3.q_nvemrrls = true;
            eTCSPacket_3.q_nvguiperm = true;
            eTCSPacket_3.q_nvsbfbperm = true;
            eTCSPacket_3.q_nvinhsmicperm = true;
            eTCSPacket_3.v_nvallowovtrp = 4294967295;
            eTCSPacket_3.v_nvsupovtrp = 4294967295;
            eTCSPacket_3.d_nvovtrp = 4294967295;
            eTCSPacket_3.t_nvovtrp = 4294967295;
            eTCSPacket_3.d_nvpotrp = 4294967295;
            eTCSPacket_3.m_nvcontact = NVContact.trainTrip;
            eTCSPacket_3.t_nvcontact = 4294967295;
            eTCSPacket_3.m_nvderun = true;
            eTCSPacket_3.d_nvstff = 4294967295;
            eTCSPacket_3.q_nvdriver_adhes = true;
            eTCSPacket_3.a_nvmaxredadh1 = 4294967295;
            eTCSPacket_3.a_nvmaxredadh2 = 4294967295;
            eTCSPacket_3.a_nvmaxredadh3 = 4294967295;
            eTCSPacket_3.q_nvlocacc = 4294967295;
            eTCSPacket_3.m_nvavadh = 4294967295;
            eTCSPacket_3.m_nvebcl = 4294967295;
            eTCSPacket_3.nkvItem = new();
            var serializer = new XmlSerializer(typeof(ETCSPacket_3));

            serializer.Serialize(writer, eTCSPacket_3, namespaces);

            string xml = writer.ToString();

            validate(xml);

            Assert.Equal("", validationOutput);

        }
        [Fact]

        public void CountryId()

        {

            

            CountryId countryId = new CountryId();
            countryId.nid_c = 4294967295;
            var serializer = new XmlSerializer(typeof(CountryId));

            serializer.Serialize(writer, countryId, namespaces);

            string xml = writer.ToString();

            validate(xml);

            Assert.Equal("", validationOutput);

        }
        [Fact]

        public void LinkItem()

        {

            

            LinkItem linkItem = new LinkItem();
            linkItem.d_link = 4294967295;
            linkItem.q_newcountry = new() {nid_c=1 };
            linkItem.nid_bg = 4294967295;
            linkItem.q_linkorientation = true;
            linkItem.q_linkreaction = LinkReaction.trainTrip;
            linkItem.q_locacc = 4294967295;
            var serializer = new XmlSerializer(typeof(LinkItem));

            serializer.Serialize(writer, linkItem, namespaces);

            string xml = writer.ToString();

            validate(xml);

            Assert.Equal("", validationOutput);

        }
        [Fact]

        public void ETCSPacket_5()

        {

            

            ETCSPacket_5 eTCSPacket_5 = new ETCSPacket_5();
            eTCSPacket_5.links = new() { new() };
            var serializer = new XmlSerializer(typeof(ETCSPacket_5));

            serializer.Serialize(writer, eTCSPacket_5, namespaces);

            string xml = writer.ToString();

            validate(xml);

            Assert.Equal("", validationOutput);

        }
        [Fact]

        public void ValidityPeriod()

        {

            

            ValidityPeriod validityPeriod = new ValidityPeriod();
            validityPeriod.t_vbc = 4294967295;
            var serializer = new XmlSerializer(typeof(ValidityPeriod));

            serializer.Serialize(writer, validityPeriod, namespaces);

            string xml = writer.ToString();

            validate(xml);

            Assert.Equal("", validationOutput);

        }
        [Fact]

        public void ETCSPacket_6()

        {

            

            ETCSPacket_6 eTCSPacket_6 = new ETCSPacket_6();
            eTCSPacket_6.nid_c = 4294967295;
            eTCSPacket_6.validityPeriod = new();
            var serializer = new XmlSerializer(typeof(ETCSPacket_6));

            serializer.Serialize(writer, eTCSPacket_6, namespaces);

            string xml = writer.ToString();

            validate(xml);

            Assert.Equal("", validationOutput);

        }
        [Fact]

        public void ETCSPacket_16()

        {

            

            ETCSPacket_16 eTCSPacket_16 = new ETCSPacket_16();
            eTCSPacket_16.l_section = 4294967295;
            var serializer = new XmlSerializer(typeof(ETCSPacket_16));

            serializer.Serialize(writer, eTCSPacket_16, namespaces);

            string xml = writer.ToString();

            validate(xml);

            Assert.Equal("", validationOutput);

        }
        [Fact]

        public void ETCSPacket_39()

        {

            

            ETCSPacket_39 eTCSPacket_39 = new ETCSPacket_39();
            eTCSPacket_39.d_traction = 4294967295;
            eTCSPacket_39.m_voltage = VoltageType.VT_none;
            eTCSPacket_39.nid_ctraction = 4294967295;
            var serializer = new XmlSerializer(typeof(ETCSPacket_39));

            serializer.Serialize(writer, eTCSPacket_39, namespaces);

            string xml = writer.ToString();

            validate(xml);

            Assert.Equal("", validationOutput);

        }
        [Fact]

        public void ETCSPacket_40()

        {

            

            ETCSPacket_40 eTCSPacket_40 = new ETCSPacket_40();
            eTCSPacket_40.d_current = 4294967295;
            eTCSPacket_40.m_current = 4294967295;
            var serializer = new XmlSerializer(typeof(ETCSPacket_40));

            serializer.Serialize(writer, eTCSPacket_40, namespaces);

            string xml = writer.ToString();

            validate(xml);

            Assert.Equal("", validationOutput);

        }
        [Fact]

        public void LevelTransitionWithAck()

        {

            

            LevelTransitionWithAck levelTransitionWithAck = new LevelTransitionWithAck();
            levelTransitionWithAck.m_leveltr = EtcsLevel.Level0;
            levelTransitionWithAck.nid_ntc_k = 4294967295;
            levelTransitionWithAck.l_ackleveltr_k = 4294967295;
            var serializer = new XmlSerializer(typeof(LevelTransitionWithAck));

            serializer.Serialize(writer, levelTransitionWithAck, namespaces);

            string xml = writer.ToString();

            validate(xml);

            Assert.Equal("", validationOutput);

        }
        [Fact]

        public void ETCSPacket_41()

        {

            

            ETCSPacket_41 eTCSPacket_41 = new ETCSPacket_41();
            eTCSPacket_41.d_leveltr = 4294967295;
            eTCSPacket_41.m_leveltr = EtcsLevel.Level0;
            eTCSPacket_41.nid_ntc = 4294967295;
            eTCSPacket_41.l_ackleveltr = 4294967295;
            eTCSPacket_41.levelTransitions = new() { new() };
            var serializer = new XmlSerializer(typeof(ETCSPacket_41));

            serializer.Serialize(writer, eTCSPacket_41, namespaces);

            string xml = writer.ToString();

            validate(xml);

            Assert.Equal("", validationOutput);

        }
        [Fact]

        public void ETCSPacket_42()

        {

            

            ETCSPacket_42 eTCSPacket_42 = new ETCSPacket_42();
            eTCSPacket_42.q_rbc = true;
            eTCSPacket_42.nid_c = 4294967295;
            eTCSPacket_42.nid_rbc = 4294967295;
            eTCSPacket_42.nid_radio = 4294967295;
            eTCSPacket_42.q_sleepsession = true;
            var serializer = new XmlSerializer(typeof(ETCSPacket_42));

            serializer.Serialize(writer, eTCSPacket_42, namespaces);

            string xml = writer.ToString();

            validate(xml);

            Assert.Equal("", validationOutput);

        }
        [Fact]

        public void ETCSPacket_44()

        {

            // Binary data (in this case, a simple string)
            byte[] binaryData = System.Text.Encoding.UTF8.GetBytes("Hello, Base64Binary!");
            // Encode binary data to Base64
            string base64Encoded = Convert.ToBase64String(binaryData);

            ETCSPacket_44 eTCSPacket_44 = new ETCSPacket_44();
            eTCSPacket_44.nid_xuser = 4294967295;
            eTCSPacket_44.nid_ntc = 4294967295;
            eTCSPacket_44.OtherData = base64Encoded;
            var serializer = new XmlSerializer(typeof(ETCSPacket_44));

            serializer.Serialize(writer, eTCSPacket_44, namespaces);

            string xml = writer.ToString();

            validate(xml);

            Assert.Equal("", validationOutput);

        }
        [Fact]

        public void ETCSPacket_45()

        {

            

            ETCSPacket_45 eTCSPacket_45 = new ETCSPacket_45();
            eTCSPacket_45.nid_mn = 4294967295;
            var serializer = new XmlSerializer(typeof(ETCSPacket_45));

            serializer.Serialize(writer, eTCSPacket_45, namespaces);

            string xml = writer.ToString();

            validate(xml);

            Assert.Equal("", validationOutput);

        }
        [Fact]

        public void LevelTransition()

        {

            

            LevelTransition levelTransition = new LevelTransition();
            levelTransition.m_leveltr = EtcsLevel.Level0;
            levelTransition.nid_ntc_k = 4294967295;
            var serializer = new XmlSerializer(typeof(LevelTransition));

            serializer.Serialize(writer, levelTransition, namespaces);

            string xml = writer.ToString();

            validate(xml);

            Assert.Equal("", validationOutput);

        }
        [Fact]

        public void ETCSPacket_46()

        {

            

            ETCSPacket_46 eTCSPacket_46 = new ETCSPacket_46();
            eTCSPacket_46.m_leveltr = EtcsLevel.Level0;
            eTCSPacket_46.nid_ntc = 4294967295;
            eTCSPacket_46.levelTransitions = new() { new() };
            var serializer = new XmlSerializer(typeof(ETCSPacket_46));

            serializer.Serialize(writer, eTCSPacket_46, namespaces);

            string xml = writer.ToString();

            validate(xml);

            Assert.Equal("", validationOutput);

        }
        [Fact]

        public void CountryBalise()

        {

            

            CountryBalise countryBalise = new CountryBalise();
            countryBalise.q_newcountry_k = true;
            countryBalise.nid_c_k = 4294967295;
            countryBalise.nid_bg_k = 4294967295;
            var serializer = new XmlSerializer(typeof(CountryBalise));

            serializer.Serialize(writer, countryBalise, namespaces);

            string xml = writer.ToString();

            validate(xml);

            Assert.Equal("", validationOutput);

        }
        [Fact]

        public void ETCSPacket_49()

        {

            

            ETCSPacket_49 eTCSPacket_49 = new ETCSPacket_49();
            eTCSPacket_49.balises = new() { new() };
            var serializer = new XmlSerializer(typeof(ETCSPacket_49));

            serializer.Serialize(writer, eTCSPacket_49, namespaces);

            string xml = writer.ToString();

            validate(xml);

            Assert.Equal("", validationOutput);

        }
        [Fact]

        public void AxleLoadRestriction()

        {

            

            AxleLoadRestriction axleLoadRestriction = new AxleLoadRestriction();
            axleLoadRestriction.m_axleloadcat_n = AxleLoadCategory.A;
            axleLoadRestriction.v_axleload_n = 4294967295;
            var serializer = new XmlSerializer(typeof(AxleLoadRestriction));

            serializer.Serialize(writer, axleLoadRestriction, namespaces);

            string xml = writer.ToString();

            validate(xml);

            Assert.Equal("", validationOutput);

        }
        [Fact]

        public void AxleLoadDLRestriction()

        {

            

            AxleLoadDLRestriction axleLoadDLRestriction = new AxleLoadDLRestriction();
            axleLoadDLRestriction.d_axleload_k = 4294967295;
            axleLoadDLRestriction.l_axleload_k = 4294967295;
            axleLoadDLRestriction.q_front_k = true;
            axleLoadDLRestriction.restrictions = new() { new() };
            var serializer = new XmlSerializer(typeof(AxleLoadDLRestriction));

            serializer.Serialize(writer, axleLoadDLRestriction, namespaces);

            string xml = writer.ToString();

            validate(xml);

            Assert.Equal("", validationOutput);

        }
        [Fact]

        public void AxleLoad()

        {

            

            AxleLoad axleLoad = new AxleLoad();
            axleLoad.d_axleload = 4294967295;
            axleLoad.l_axleload = 4294967295;
            axleLoad.q_front = true;
            axleLoad.axleLoadDLRestrictions = new() { new() };
            var serializer = new XmlSerializer(typeof(AxleLoad));

            serializer.Serialize(writer, axleLoad, namespaces);

            string xml = writer.ToString();

            validate(xml);

            Assert.Equal("", validationOutput);

        }
        [Fact]

        public void AxleLoadSelection()

        {

            

            AxleLoadSelection axleLoadSelection = new AxleLoadSelection();
            axleLoadSelection.axleLoad = new();
            var serializer = new XmlSerializer(typeof(AxleLoadSelection));

            serializer.Serialize(writer, axleLoadSelection, namespaces);

            string xml = writer.ToString();

            validate(xml);

            Assert.Equal("", validationOutput);

        }
        [Fact]

        public void ETCSPacket_51()

        {

            

            ETCSPacket_51 eTCSPacket_51 = new ETCSPacket_51();
            eTCSPacket_51.axleLoadSelection = new() {axleLoad=new() };
            var serializer = new XmlSerializer(typeof(ETCSPacket_51));

            serializer.Serialize(writer, eTCSPacket_51, namespaces);

            string xml = writer.ToString();

            validate(xml);

            Assert.Equal("", validationOutput);

        }
        [Fact]

        public void PermittedBrakingDist()

        {

            

            PermittedBrakingDist permittedBrakingDist = new PermittedBrakingDist();
            permittedBrakingDist.d_pbd = 4294967295;
            permittedBrakingDist.q_gdir = true;
            permittedBrakingDist.g_pbdsr = 4294967295;
            permittedBrakingDist.q_pbdsr = true;
            permittedBrakingDist.d_pbdsr = 4294967295;
            permittedBrakingDist.l_pbdsr = 4294967295;
            var serializer = new XmlSerializer(typeof(PermittedBrakingDist));

            serializer.Serialize(writer, permittedBrakingDist, namespaces);

            string xml = writer.ToString();

            validate(xml);

            Assert.Equal("", validationOutput);

        }
        [Fact]

        public void PBDSelection()

        {

            

            PBDSelection pBDSelection = new PBDSelection();
            pBDSelection.pbds = new() { new() };
            var serializer = new XmlSerializer(typeof(PBDSelection));

            serializer.Serialize(writer, pBDSelection, namespaces);

            string xml = writer.ToString();

            validate(xml);

            Assert.Equal("", validationOutput);

        }
        [Fact]

        public void ETCSPacket_52()

        {

            

            ETCSPacket_52 eTCSPacket_52 = new ETCSPacket_52();
            eTCSPacket_52.pbdSelection = new();
            var serializer = new XmlSerializer(typeof(ETCSPacket_52));

            serializer.Serialize(writer, eTCSPacket_52, namespaces);

            string xml = writer.ToString();

            validate(xml);

            Assert.Equal("", validationOutput);

        }
        [Fact]

        public void ETCSPacket_65()

        {

            

            ETCSPacket_65 eTCSPacket_65 = new ETCSPacket_65();
            eTCSPacket_65.nid_tsr = 4294967295;
            eTCSPacket_65.d_tsr = 4294967295;
            eTCSPacket_65.l_tsr = 4294967295;
            eTCSPacket_65.q_front = true;
            eTCSPacket_65.v_tsr = 4294967295;
            var serializer = new XmlSerializer(typeof(ETCSPacket_65));

            serializer.Serialize(writer, eTCSPacket_65, namespaces);

            string xml = writer.ToString();

            validate(xml);

            Assert.Equal("", validationOutput);

        }
        [Fact]

        public void ETCSPacket_66()

        {

            

            ETCSPacket_66 eTCSPacket_66 = new ETCSPacket_66();
            eTCSPacket_66.nid_tsr = 4294967295;
            var serializer = new XmlSerializer(typeof(ETCSPacket_66));

            serializer.Serialize(writer, eTCSPacket_66, namespaces);

            string xml = writer.ToString();

            validate(xml);

            Assert.Equal("", validationOutput);

        }
        [Fact]

        public void DLTrackCond()

        {

            

            DLTrackCond dLTrackCond = new DLTrackCond();
            dLTrackCond.d_trackcond = 4294967295;
            dLTrackCond.l_trackcond = 4294967295;
            var serializer = new XmlSerializer(typeof(DLTrackCond));

            serializer.Serialize(writer, dLTrackCond, namespaces);

            string xml = writer.ToString();

            validate(xml);

            Assert.Equal("", validationOutput);

        }
        [Fact]

        public void ETCSPacket_67()

        {

            

            ETCSPacket_67 eTCSPacket_67 = new ETCSPacket_67();
            eTCSPacket_67.trackConditions = new() { new() };
            var serializer = new XmlSerializer(typeof(ETCSPacket_67));

            serializer.Serialize(writer, eTCSPacket_67, namespaces);

            string xml = writer.ToString();

            validate(xml);

            Assert.Equal("", validationOutput);

        }
        [Fact]

        public void DLMCondition()

        {

            

            DLMCondition dLMCondition = new DLMCondition();
            dLMCondition.d_trackcond = 4294967295;
            dLMCondition.l_trackcond = 4294967295;
            dLMCondition.m_trackcond = TrackCondType.TCT_0000;
            var serializer = new XmlSerializer(typeof(DLMCondition));

            serializer.Serialize(writer, dLMCondition, namespaces);

            string xml = writer.ToString();

            validate(xml);

            Assert.Equal("", validationOutput);

        }
        [Fact]

        public void TrackCondSelection()

        {

            

            TrackCondSelection trackCondSelection = new TrackCondSelection();
            trackCondSelection.dlmConds = new() { new() };
            var serializer = new XmlSerializer(typeof(TrackCondSelection));

            serializer.Serialize(writer, trackCondSelection, namespaces);

            string xml = writer.ToString();

            validate(xml);

            Assert.Equal("", validationOutput);

        }
        [Fact]

        public void ETCSPacket_68()

        {

            

            ETCSPacket_68 eTCSPacket_68 = new ETCSPacket_68();
            eTCSPacket_68.trackCondSelection = new();
            var serializer = new XmlSerializer(typeof(ETCSPacket_68));

            serializer.Serialize(writer, eTCSPacket_68, namespaces);

            string xml = writer.ToString();

            validate(xml);

            Assert.Equal("", validationOutput);

        }
        [Fact]

        public void TCSPCondition()

        {

            

            TCSPCondition tCSPCondition = new TCSPCondition();
            tCSPCondition.d_trackcond = 4294967295;
            tCSPCondition.l_trackcond = 4294967295;
            tCSPCondition.m_platform = PlatformType.PT_200;
            tCSPCondition.q_platform = PlatformPosition.PP_left;
            var serializer = new XmlSerializer(typeof(TCSPCondition));

            serializer.Serialize(writer, tCSPCondition, namespaces);

            string xml = writer.ToString();

            validate(xml);

            Assert.Equal("", validationOutput);

        }
        [Fact]

        public void TrackCondPlatformSelection()

        {

            

            TrackCondPlatformSelection trackCondPlatformSelection = new TrackCondPlatformSelection();
            trackCondPlatformSelection.tcspConds = new() { new() };
            var serializer = new XmlSerializer(typeof(TrackCondPlatformSelection));

            serializer.Serialize(writer, trackCondPlatformSelection, namespaces);

            string xml = writer.ToString();

            validate(xml);

            Assert.Equal("", validationOutput);

        }
        [Fact]

        public void ETCSPacket_69()

        {

            

            ETCSPacket_69 eTCSPacket_69 = new ETCSPacket_69();
            eTCSPacket_69.trackCondPlatformSelection = new();
            var serializer = new XmlSerializer(typeof(ETCSPacket_69));

            serializer.Serialize(writer, eTCSPacket_69, namespaces);

            string xml = writer.ToString();

            validate(xml);

            Assert.Equal("", validationOutput);

        }
        [Fact]

        public void TractionSystem()

        {

            

            TractionSystem tractionSystem = new TractionSystem();
            tractionSystem.d_voltage = VoltageType.VT_none;
            tractionSystem.nid_ctraction = 4294967295;
            var serializer = new XmlSerializer(typeof(TractionSystem));

            serializer.Serialize(writer, tractionSystem, namespaces);

            string xml = writer.ToString();

            validate(xml);

            Assert.Equal("", validationOutput);

        }
        [Fact]

        public void RouteSuitability()

        {

            

            RouteSuitability routeSuitability = new RouteSuitability();
            routeSuitability.loadingGauge = 4294967295;
            routeSuitability.voltage = new();
            var serializer = new XmlSerializer(typeof(RouteSuitability));

            serializer.Serialize(writer, routeSuitability, namespaces);

            string xml = writer.ToString();

            validate(xml);

            Assert.Equal("", validationOutput);

        }
        [Fact]

        public void ETCSPacket_70()

        {

            

            ETCSPacket_70 eTCSPacket_70 = new ETCSPacket_70();
            eTCSPacket_70.routeSuitabilities = new() { new() {voltage=new() } };
            var serializer = new XmlSerializer(typeof(ETCSPacket_70));

            serializer.Serialize(writer, eTCSPacket_70, namespaces);

            string xml = writer.ToString();

            validate(xml);

            Assert.Equal("", validationOutput);

        }
        [Fact]

        public void ETCSPacket_71()

        {

            

            ETCSPacket_71 eTCSPacket_71 = new ETCSPacket_71();
            eTCSPacket_71.d_adhesion = 4294967295;
            eTCSPacket_71.l_adhesion = 4294967295;
            eTCSPacket_71.m_adhesion = true;
            var serializer = new XmlSerializer(typeof(ETCSPacket_71));

            serializer.Serialize(writer, eTCSPacket_71, namespaces);

            string xml = writer.ToString();

            validate(xml);

            Assert.Equal("", validationOutput);

        }
        [Fact]

        public void ETCSPacket_72()

        {

            

            ETCSPacket_72 eTCSPacket_72 = new ETCSPacket_72();
            eTCSPacket_72.q_textclass = TextClass.TC_auxiliary;
            eTCSPacket_72.q_textdisplay = true;
            eTCSPacket_72.d_textdisplay = 4294967295;
            eTCSPacket_72.m_modetextdisplay = DisplayOperatingMode.DOM_fullSupervision;
            eTCSPacket_72.m_leveltextdisplay = DisplayOperatingLevel.DOL_level0;
            eTCSPacket_72.nid_ntc = 4294967295;
            eTCSPacket_72.l_textdisplay = 4294967295;
            eTCSPacket_72.t_textdisplay = 4294967295;
            eTCSPacket_72.q_textconfirm = TextConfirmationType.TCT_00;
            eTCSPacket_72.q_conftextdisplay = true;
            eTCSPacket_72.q_textreport = true;
            eTCSPacket_72.nid_textmessage = 4294967295;
            eTCSPacket_72.nid_c = 4294967295;
            eTCSPacket_72.nid_rbc = 4294967295;
            eTCSPacket_72.Text = "HelloWorld";
            var serializer = new XmlSerializer(typeof(ETCSPacket_72));

            serializer.Serialize(writer, eTCSPacket_72, namespaces);

            string xml = writer.ToString();

            validate(xml);

            Assert.Equal("", validationOutput);

        }
        [Fact]

        public void ETCSPacket_76()

        {

            

            ETCSPacket_76 eTCSPacket_76 = new ETCSPacket_76();
            var serializer = new XmlSerializer(typeof(ETCSPacket_76));

            serializer.Serialize(writer, eTCSPacket_76, namespaces);

            string xml = writer.ToString();

            validate(xml);

            Assert.Equal("", validationOutput);

        }
        [Fact]

        public void NewCountry()

        {

            

            NewCountry newCountry = new NewCountry();
            newCountry.nid_c = 4294967295;
            var serializer = new XmlSerializer(typeof(NewCountry));

            serializer.Serialize(writer, newCountry, namespaces);

            string xml = writer.ToString();

            validate(xml);

            Assert.Equal("", validationOutput);

        }
        [Fact]

        public void GeoPosItem()

        {

            

            GeoPosItem geoPosItem = new GeoPosItem();
            geoPosItem.newCountry = new() {nid_c=1 };
            geoPosItem.nid_bg = 4294967295;
            geoPosItem.d_posoff = 4294967295;
            geoPosItem.q_mposition = true;
            geoPosItem.m_position = 4294967295;
            var serializer = new XmlSerializer(typeof(GeoPosItem));

            serializer.Serialize(writer, geoPosItem, namespaces);

            string xml = writer.ToString();

            validate(xml);

            Assert.Equal("", validationOutput);

        }
        [Fact]

        public void ETCSPacket_79()

        {

            

            ETCSPacket_79 eTCSPacket_79 = new ETCSPacket_79();
            eTCSPacket_79.geoPosItems = new() { new() };
            var serializer = new XmlSerializer(typeof(ETCSPacket_79));

            serializer.Serialize(writer, eTCSPacket_79, namespaces);

            string xml = writer.ToString();

            validate(xml);

            Assert.Equal("", validationOutput);

        }
        [Fact]

        public void ModeProfileItem()

        {

            

            ModeProfileItem modeProfileItem = new ModeProfileItem();
            modeProfileItem.d_mamode = 4294967295;
            modeProfileItem.m_mamode = MAMode.MAM_OS;
            modeProfileItem.v_mamode = 4294967295;
            modeProfileItem.l_mamode = 4294967295;
            modeProfileItem.l_ackmamode = 4294967295;
            modeProfileItem.q_mamode = true;
            var serializer = new XmlSerializer(typeof(ModeProfileItem));

            serializer.Serialize(writer, modeProfileItem, namespaces);

            string xml = writer.ToString();

            validate(xml);

            Assert.Equal("", validationOutput);

        }
        [Fact]

        public void ETCSPacket_80()

        {

            

            ETCSPacket_80 eTCSPacket_80 = new ETCSPacket_80();
            eTCSPacket_80.modeProfiles = new() { new() };
            var serializer = new XmlSerializer(typeof(ETCSPacket_80));

            serializer.Serialize(writer, eTCSPacket_80, namespaces);

            string xml = writer.ToString();

            validate(xml);

            Assert.Equal("", validationOutput);

        }
        [Fact]

        public void LXStatus()

        {

            

            LXStatus lXStatus = new LXStatus();
            lXStatus.v_lx = 4294967295;
            lXStatus.q_stoplx = true;
            lXStatus.l_stoplx = 4294967295;
            var serializer = new XmlSerializer(typeof(LXStatus));

            serializer.Serialize(writer, lXStatus, namespaces);

            string xml = writer.ToString();

            validate(xml);

            Assert.Equal("", validationOutput);

        }
        [Fact]

        public void ETCSPacket_88()

        {

            

            ETCSPacket_88 eTCSPacket_88 = new ETCSPacket_88();
            eTCSPacket_88.nid_lx = 4294967295;
            eTCSPacket_88.d_lx = 4294967295;
            eTCSPacket_88.l_lx = 4294967295;
            eTCSPacket_88.lxStatus = new();
            var serializer = new XmlSerializer(typeof(ETCSPacket_88));

            serializer.Serialize(writer, eTCSPacket_88, namespaces);

            string xml = writer.ToString();

            validate(xml);

            Assert.Equal("", validationOutput);

        }
        [Fact]

        public void ETCSPacket_90()

        {

            

            ETCSPacket_90 eTCSPacket_90 = new ETCSPacket_90();
            eTCSPacket_90.newCountry = new();
            eTCSPacket_90.nid_bg = 4294967295;
            var serializer = new XmlSerializer(typeof(ETCSPacket_90));

            serializer.Serialize(writer, eTCSPacket_90, namespaces);

            string xml = writer.ToString();

            validate(xml);

            Assert.Equal("", validationOutput);

        }
        [Fact]

        public void ETCSPacket_131()

        {

            

            ETCSPacket_131 eTCSPacket_131 = new ETCSPacket_131();
            eTCSPacket_131.d_rbctr = 4294967295;
            eTCSPacket_131.nid_c = 4294967295;
            eTCSPacket_131.nid_rbc = 4294967295;
            eTCSPacket_131.nid_radio = 4294967295;
            eTCSPacket_131.q_sleepsession = true;
            var serializer = new XmlSerializer(typeof(ETCSPacket_131));

            serializer.Serialize(writer, eTCSPacket_131, namespaces);

            string xml = writer.ToString();

            validate(xml);

            Assert.Equal("", validationOutput);

        }
        [Fact]

        public void ETCSPacket_132()

        {

            

            ETCSPacket_132 eTCSPacket_132 = new ETCSPacket_132();
            eTCSPacket_132.q_aspect = true;
            var serializer = new XmlSerializer(typeof(ETCSPacket_132));

            serializer.Serialize(writer, eTCSPacket_132, namespaces);

            string xml = writer.ToString();

            validate(xml);

            Assert.Equal("", validationOutput);

        }
        [Fact]

        public void ETCSPacket_133()

        {

            

            ETCSPacket_133 eTCSPacket_133 = new ETCSPacket_133();
            eTCSPacket_133.q_riu = true;
            eTCSPacket_133.nid_c = 4294967295;
            eTCSPacket_133.nid_riu = 4294967295;
            eTCSPacket_133.nid_radio = 4294967295;
            eTCSPacket_133.d_infill = 4294967295;
            eTCSPacket_133.nid_bg = 4294967295;
            var serializer = new XmlSerializer(typeof(ETCSPacket_133));

            serializer.Serialize(writer, eTCSPacket_133, namespaces);

            string xml = writer.ToString();

            validate(xml);

            Assert.Equal("", validationOutput);

        }
        [Fact]

        public void ETCSPacket_134()

        {

            

            ETCSPacket_134 eTCSPacket_134 = new ETCSPacket_134();
            eTCSPacket_134.nid_loop = 4294967295;
            eTCSPacket_134.d_loop = 4294967295;
            eTCSPacket_134.l_loop = 4294967295;
            eTCSPacket_134.q_loopdir = true;
            eTCSPacket_134.q_sscode = 4294967295;
            var serializer = new XmlSerializer(typeof(ETCSPacket_134));

            serializer.Serialize(writer, eTCSPacket_134, namespaces);

            string xml = writer.ToString();

            validate(xml);

            Assert.Equal("", validationOutput);

        }
        [Fact]

        public void ETCSPacket_135()

        {

            

            ETCSPacket_135 eTCSPacket_135 = new ETCSPacket_135();
            var serializer = new XmlSerializer(typeof(ETCSPacket_135));

            serializer.Serialize(writer, eTCSPacket_135, namespaces);

            string xml = writer.ToString();

            validate(xml);

            Assert.Equal("", validationOutput);

        }
        [Fact]

        public void ETCSPacket_136()

        {

            

            ETCSPacket_136 eTCSPacket_136 = new ETCSPacket_136();
            eTCSPacket_136.newCountry =  new() {nid_c=1 };
            eTCSPacket_136.nid_bg = 4294967295;
            var serializer = new XmlSerializer(typeof(ETCSPacket_136));

            serializer.Serialize(writer, eTCSPacket_136, namespaces);

            string xml = writer.ToString();

            validate(xml);

            Assert.Equal("", validationOutput);

        }
        [Fact]

        public void ETCSPacket_137()

        {

            

            ETCSPacket_137 eTCSPacket_137 = new ETCSPacket_137();
            eTCSPacket_137.q_srstop = true;
            var serializer = new XmlSerializer(typeof(ETCSPacket_137));

            serializer.Serialize(writer, eTCSPacket_137, namespaces);

            string xml = writer.ToString();

            validate(xml);

            Assert.Equal("", validationOutput);

        }
        [Fact]

        public void ETCSPacket_138()

        {

            

            ETCSPacket_138 eTCSPacket_138 = new ETCSPacket_138();
            eTCSPacket_138.d_startreverse = 4294967295;
            eTCSPacket_138.l_reversearea = 4294967295;
            var serializer = new XmlSerializer(typeof(ETCSPacket_138));

            serializer.Serialize(writer, eTCSPacket_138, namespaces);

            string xml = writer.ToString();

            validate(xml);

            Assert.Equal("", validationOutput);

        }
        [Fact]

        public void ETCSPacket_139()

        {

            

            ETCSPacket_139 eTCSPacket_139 = new ETCSPacket_139();
            eTCSPacket_139.d_reverse = 4294967295;
            eTCSPacket_139.v_reverse = 4294967295;
            var serializer = new XmlSerializer(typeof(ETCSPacket_139));

            serializer.Serialize(writer, eTCSPacket_139, namespaces);

            string xml = writer.ToString();

            validate(xml);

            Assert.Equal("", validationOutput);

        }
        [Fact]

        public void ETCSPacket_141()

        {

            

            ETCSPacket_141 eTCSPacket_141 = new ETCSPacket_141();
            eTCSPacket_141.g_tsr = -2147483647;
            var serializer = new XmlSerializer(typeof(ETCSPacket_141));

            serializer.Serialize(writer, eTCSPacket_141, namespaces);

            string xml = writer.ToString();

            validate(xml);

            Assert.Equal("", validationOutput);

        }
        [Fact]

        public void ETCSPacket_145()

        {

            

            ETCSPacket_145 eTCSPacket_145 = new ETCSPacket_145();
            var serializer = new XmlSerializer(typeof(ETCSPacket_145));

            serializer.Serialize(writer, eTCSPacket_145, namespaces);

            string xml = writer.ToString();

            validate(xml);

            Assert.Equal("", validationOutput);

        }
        [Fact]

        public void ETCSPacket_180()

        {

            

            ETCSPacket_180 eTCSPacket_180 = new ETCSPacket_180();
            eTCSPacket_180.q_lssma = true;
            eTCSPacket_180.t_lssma = 4294967295;
            var serializer = new XmlSerializer(typeof(ETCSPacket_180));

            serializer.Serialize(writer, eTCSPacket_180, namespaces);

            string xml = writer.ToString();

            validate(xml);

            Assert.Equal("", validationOutput);

        }
        [Fact]

        public void ETCSPacket_181()

        {

            

            ETCSPacket_181 eTCSPacket_181 = new ETCSPacket_181();
            var serializer = new XmlSerializer(typeof(ETCSPacket_181));

            serializer.Serialize(writer, eTCSPacket_181, namespaces);

            string xml = writer.ToString();

            validate(xml);

            Assert.Equal("", validationOutput);

        }
        [Fact]

        public void ETCSPacket_254()

        {

            

            ETCSPacket_254 eTCSPacket_254 = new ETCSPacket_254();
            var serializer = new XmlSerializer(typeof(ETCSPacket_254));

            serializer.Serialize(writer, eTCSPacket_254, namespaces);

            string xml = writer.ToString();

            validate(xml);

            Assert.Equal("", validationOutput);

        }
        [Fact]

        public void ETCSPacket_255()

        {

            

            ETCSPacket_255 eTCSPacket_255 = new ETCSPacket_255();
            var serializer = new XmlSerializer(typeof(ETCSPacket_255));

            serializer.Serialize(writer, eTCSPacket_255, namespaces);

            string xml = writer.ToString();

            validate(xml);

            Assert.Equal("", validationOutput);

        }

    }
}