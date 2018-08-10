using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.IO;


namespace AppendXML
{
    class Program
    {
        static void Main(string[] args)
        {
            XmlDocument doc = new XmlDocument();
            XmlElement books;
            if (File.Exists("Books.xml"))
            {
                doc.Load("Books.xml");
                 books = doc.DocumentElement;
            }
            else
            {
                XmlDeclaration dec = doc.CreateXmlDeclaration("1.0", "utf-8", null);
                doc.AppendChild(dec);

                books = doc.CreateElement("Books");
                doc.AppendChild(books);
            }

            XmlElement book1 = doc.CreateElement("Book");
            books.AppendChild(book1);

            XmlElement name1 = doc.CreateElement("Name");
            name1.InnerText = "C# 101";
            book1.AppendChild(name1);

            XmlElement price1 = doc.CreateElement("Price");
            price1.InnerText = "10";
            book1.AppendChild(price1);

            XmlElement des1 = doc.CreateElement("Desc");
            des1.InnerText = "Magic!";
            book1.AppendChild(des1);

            doc.Save("Books.xml");
            Console.WriteLine("Good!");
            Console.ReadKey();
        }
    }
}
