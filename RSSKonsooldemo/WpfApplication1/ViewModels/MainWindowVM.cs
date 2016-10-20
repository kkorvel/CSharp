using System;
using System.Collections.Generic;
using  System.Collections.ObjectModel;
using System.Linq;
using System.Xml.Linq;
using WpfApplication1.Models;
namespace WpfApplication1.ViewModels
{
    public class MainWindowVM
    {
        private ObservableCollection<Uudis> _uudised;
        private string _rssUrl;

        public ObservableCollection<Uudis> _uusUudis;


        public MainWindowVM(string rssurl)
        {
            _uudised = new ObservableCollection<Uudis>();
            _rssUrl = rssurl;

         
        }

        public ObservableCollection<Uudis> Uudis1
        {
            get { return _uusUudis; }
            set { _uusUudis = value; }
        }


        public void LaeAndmed()
        {
            XDocument xdoc = XDocument.Load(_rssUrl);


            //Descendants(arvatavastu kõige olulisem meetod),
            //võimaldab xml´i elemendid üles leida elemendi nime järgi
            IEnumerable<XElement> query = from x in xdoc.Descendants("item")
                                          select x;

            //item - XElement ehk siis XML element
            //item.Value - elemendi väärtus.
            foreach (var item in query)
            {

                XElement xTitle = item.Element("title");
                if (xTitle != null)
                {
                    Uudis uusUudis = new Uudis() {Pealkiri = xTitle.Value};
                    _uudised.Add(uusUudis);
                }


                //Console.WriteLine(item.Element("title").Value);
                //XElement xDescription = item.Element("description");
                //if (xDescription != null)
                //{
                //    Console.WriteLine(xDescription.Value);
                //}
                //Console.WriteLine("----");
            }
        }

    }
}