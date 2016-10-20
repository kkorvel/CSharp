using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//NB!
//Et saaksime kasutada XML-i!
using System.Xml.Linq;


namespace RSSKonsool
{
    class Program
    {
        static void Main(string[] args)
        {

            //XDocument xdoc = XDocument.Load("http://www.postimees.ee/rss/");


            ////Descendants(arvatavastu kõige olulisem meetod),
            ////võimaldab xml´i elemendid üles leida elemendi nime järgi
            //IEnumerable<XElement> query = from x in xdoc.Descendants("item")
            //    select x;

            ////item - XElement ehk siis XML element
            ////item.Value - elemendi väärtus.
            //foreach (var item in query)
            //{

            //    XElement xTitle = item.Element("Title");
            //    if (xTitle != null)
            //    {
            //        Console.WriteLine(xTitle.Value);
            //    }


            //    //Console.WriteLine(item.Element("title").Value);
            //    XElement xDescription = item.Element("description");
            //    if (xDescription !=null)
            //    {
            //        Console.WriteLine(xDescription.Value);
            //    }
            //    Console.WriteLine("----");
            //}
            
        }
    }
}
