using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace XMLwProp
{
    class Program
    {
        static void Main(string[] args)
        {
            XmlDocument doc = new XmlDocument();
            XmlDeclaration dec = doc.CreateXmlDeclaration("1.0", "uft-8", null);

            XmlElement order = doc.CreateElement("Order");
            doc.AppendChild(order);

            XmlElement customerName = doc.CreateElement("CustomerName");
            customerName.InnerText = "Sam";
            order.AppendChild(customerName);

            XmlElement customerNumber = doc.CreateElement("CustomerNumber");
            customerNumber.InnerText = "1000022";
            order.AppendChild(customerNumber);

            XmlElement items = doc.CreateElement("Items");
           
            order.AppendChild(items);

            XmlElement item1 = doc.CreateElement("Items");
            item1.SetAttribute("Name", "Mouse");
            item1.SetAttribute("Amount", "2");
            items.AppendChild(item1);

            XmlElement item2 = doc.CreateElement("Items");
            item2.SetAttribute("Name", "Key Board");
            item2.SetAttribute("Amount", "1");
            items.AppendChild(item2);

            XmlElement item3 = doc.CreateElement("Items");
            item3.SetAttribute("Name", "Monitor");
            item3.SetAttribute("Amount", "2");
            items.AppendChild(item3);

            doc.Save("Orders.xml");

            Console.WriteLine("Good");
            Console.ReadKey();





        }
    }
}
