using System.Xml;
using System.Xml.Linq;

namespace Backend.Server
{
    public class ReadXml
    {
        public static string ccNumber, pinNumber, api;

        public static void Read(string xmlString)
        {
            xmlString = xmlString.Substring(0, xmlString.IndexOf("<EOF>", 0));
            XDocument xmlNode = XDocument.Parse(xmlString);

            foreach (var element in xmlNode.Elements())
            {
                api = element.Name.ToString();
                if (api == "LoginData")
                {
                    foreach (XElement xe in element.Descendants())
                    {
                        if (xe.Name == "CcNumber")
                        {
                            ccNumber = xe.Value.ToString();
                        } else
                        {
                            pinNumber = xe.Value.ToString();
                        }
                        System.Console.WriteLine(xe.Name);
                        System.Console.WriteLine(xe.Value);
                        //ccNumber = xe.Element("CcNumber").Value;
                        //pinNumber = xe.Element("PinNumber").Value;
                    }
                    System.Console.WriteLine(ccNumber);
                    System.Console.WriteLine(pinNumber);
                }
            }
        }
    }
}
