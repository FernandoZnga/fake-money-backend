using System.Xml;
using System.Xml.Linq;

namespace Backend.Server
{
    public class ReadXml
    {
        public static void Read(string xmlString)
        {
            xmlString = xmlString.Substring(0, xmlString.IndexOf("<EOF>", 0));
            XDocument xmlNode = XDocument.Parse(xmlString);

            foreach (var element in xmlNode.Root.Elements())
            {
                System.Console.WriteLine("1");
                System.Console.WriteLine(element.Name);
                foreach (var attribute in element.Descendants())
                {
                    System.Console.WriteLine(attribute.Name);
                    System.Console.WriteLine(attribute.Value);
                }
            }
        }
    }
}
