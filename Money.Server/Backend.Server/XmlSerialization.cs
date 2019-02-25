using System;
using System.IO;
using System.Xml.Serialization;

namespace Backend.Server
{
    public class XmlSerialization
    {
        public static string UserData(int id, string firstName, string lastName)
        {
            Objects.UserData userData = new Objects.UserData
            {
                Id = id,
                FirstName = firstName,
                LastName = lastName
            };
            XmlSerializer x = new XmlSerializer(userData.GetType());
            using (StringWriter textWriter = new StringWriter())
            {
                x.Serialize(Console.Out, userData);
                Console.WriteLine();
                Console.ReadLine();
                x.Serialize(textWriter, userData);
                return textWriter.ToString();
            }
        }
        public static string Response(string value)
        {
            Objects.Response response = new Objects.Response
            {
                Value = value
            };
            XmlSerializer x = new XmlSerializer(response.GetType());
            using (StringWriter textWriter = new StringWriter())
            {
                x.Serialize(Console.Out, response);
                Console.WriteLine();
                Console.ReadLine();
                x.Serialize(textWriter, response);
                return textWriter.ToString();
            }
        }
    }
}
