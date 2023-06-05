using System.Text;
using System.Text.Json;
using System.Xml.Serialization;
using static System.Net.Mime.MediaTypeNames;
using System.Xml;
using System.Xml.Schema;
using System.Data.SqlTypes;
using ERJUfeedData;
using System;
using topo;
using eng;

public class Program
{
    public static void Main(string[] args)
    {
        readData("FuncArea.xml", "EngArea.xml");
    } 


    public static void readData(string funcAreaXMLpath,string engAreaXMLpath)
    {
        XmlSerializer serializerFunc = new XmlSerializer(typeof(FunctionalArea));
        XmlSerializer serializerEng = new XmlSerializer(typeof(EngArea));
        FunctionalArea funcArea;
        EngArea engArea;
        using (FileStream fileStream = new FileStream(funcAreaXMLpath, FileMode.Open))
        {
            using (StreamReader reader = new StreamReader(fileStream, Encoding.Default, true))
            {
                funcArea = (FunctionalArea)serializerFunc.Deserialize(fileStream);
            }
                
        }
        using (FileStream fileStream = new FileStream(engAreaXMLpath, FileMode.Open))
        {
            using (StreamReader reader = new StreamReader(fileStream, Encoding.Default, true))
            {
                engArea = (EngArea)serializerEng.Deserialize(fileStream);
            }
        }
    }
}
