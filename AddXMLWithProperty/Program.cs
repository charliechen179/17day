using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace AddXMLWithProperty
{
    class Program
    {
        static void Main(string[] args)
        {
            XmlDocument doc = new XmlDocument();
            XmlDeclaration dec = doc.CreateXmlDeclaration("1.0", "utf-8", null);
            doc.AppendChild(dec);

            XmlElement order = doc.CreateElement("Order");
            doc.AppendChild(order);

            XmlElement customerName = doc.CreateElement("CustomerName");
            customerName.InnerText = "Yonge";
            order.AppendChild(customerName);

            XmlElement orderNumber = doc.CreateElement("OrderNumber");
            customerName.InnerText = "ON88932";
            order.AppendChild(orderNumber);

            XmlElement items = doc.CreateElement("Items");
            order.AppendChild(items);

            XmlElement orderItem1 = doc.CreateElement("OrderItem");
            orderItem1.SetAttribute("Name","Stop Watch");
            orderItem1.SetAttribute("Count", "10");
            items.AppendChild(orderItem1);

            XmlElement orderItem2 = doc.CreateElement("OrderItem");
            orderItem2.SetAttribute("Name", "Rain Coat");
            orderItem2.SetAttribute("Count", "11");
            items.AppendChild(orderItem2);

            XmlElement orderItem3 = doc.CreateElement("OrderItem");
            orderItem3.SetAttribute("Name", "Pen");
            orderItem3.SetAttribute("Count", "20");
            items.AppendChild(orderItem3);







            doc.Save("Order.xml");
            Console.WriteLine("Save succeeded.");
            Console.ReadKey();

        }
    }
}
