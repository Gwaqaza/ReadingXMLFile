using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.IO;
using System.Xml.Linq;

namespace ConsoleReadingApp
{
    class Program
    {
        const string xmlFile = @"C:\\Users\\bbdnet1963\\Desktop\data.xml";
        static void Main(string[] args)
        {
            var elements = string.Empty;
            int total = 0;
            XDocument doc = XDocument.Load(xmlFile);
            var randomRead = doc.Descendants();
            try
            {
                var valid = doc.Descendants().Where(x => x.HasAttributes).Select(x => Int32.Parse(x.Value));
                //Where(x => x.HasAttributes).Value;
                total = valid.Sum();

                //foreach (XElement nodes in valid)
                //{
                //    try
                //    {
                //        if (nodes.HasAttributes)
                //        {
                //            elements = (nodes.Attribute("Count").Value);
                //            total += Convert.ToInt32(elements);
                //        }

                //    } catch (Exception ex)
                //    {
                //        Console.WriteLine(ex.Message);
                //    }
                //    //Console.WriteLine(elements);
                //}
            } catch (Exception ex) { }
            string appendString = total.AppendExtensionMethod();

            Console.WriteLine(appendString);
            Console.ReadLine();
        }
    }
}
