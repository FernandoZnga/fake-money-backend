using System;
using System.Xml;
using System.Xml.Serialization;
using System.IO;
using Backend.Domain;

public class XmlSerialization
{
    /*public static void Main(string ccNumber, string passWord)
    {
        // Read and write purchase orders.
        XmlSerialization t = new XmlSerialization();
        t.CreateLoginData("login.xml",ccNumber,passWord);
        t.ReadLoginData("login.xml");
    }*/

    public static void CreateLoginData(string filename, string ccNumber, string passWord)
    {
        // Create an instance of the XmlSerializer class;
        // specify the type of object to serialize.
        XmlSerializer serializer =
        new XmlSerializer(typeof(Objects.CheckCcPinNumber));
        TextWriter writer = new StreamWriter(filename);
        Objects.CheckCcPinNumber login = new Objects.CheckCcPinNumber();

        // Create an address to ship and bill to.
        login.CcNumber = ccNumber;
        login.PinNumber = passWord;

        // Serialize the purchase order, and close the TextWriter.
        serializer.Serialize(writer, login);
        writer.Close();
    }

    public static void ReadLoginData(string filename)
    {
        // Create an instance of the XmlSerializer class;
        // specify the type of object to be deserialized.
        XmlSerializer serializer = new XmlSerializer(typeof(Objects.CheckCcPinNumber));
        /* If the XML document has been altered with unknown 
        nodes or attributes, handle them with the 
        UnknownNode and UnknownAttribute events.*/
        serializer.UnknownNode += new
        XmlNodeEventHandler(serializer_UnknownNode);
        serializer.UnknownAttribute += new
        XmlAttributeEventHandler(serializer_UnknownAttribute);

        // A FileStream is needed to read the XML document.
        FileStream fs = new FileStream(filename, FileMode.Open);
        // Declare an object variable of the type to be deserialized.
        Objects.CheckCcPinNumber login;
        /* Use the Deserialize method to restore the object's state with
        data from the XML document. */
        login = (Objects.CheckCcPinNumber)serializer.Deserialize(fs);
        // Read the order date.
        Console.WriteLine("Cc-Number: " + login.CcNumber);
        Console.WriteLine("Pin-Number: " + login.PinNumber);
    }

    private static void serializer_UnknownNode
    (object sender, XmlNodeEventArgs e)
    {
        Console.WriteLine("Unknown Node:" + e.Name + "\t" + e.Text);
    }

    private static void serializer_UnknownAttribute
    (object sender, XmlAttributeEventArgs e)
    {
        System.Xml.XmlAttribute attr = e.Attr;
        Console.WriteLine("Unknown attribute " +
        attr.Name + "='" + attr.Value + "'");
    }
}