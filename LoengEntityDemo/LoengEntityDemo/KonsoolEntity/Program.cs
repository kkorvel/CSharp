using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KonsoolEntity
{
    class Program
    {
        static void Main(string[] args)
        {
            leiaInimeneineIDJargi(1);
            //muudaAndmeid(1, "Peeter-Ants", "Pakiraam");

            //lisaInimene("Margus", "Kopter");
            // kuvaInimesed();

        }

        static void kuvaInimesed()
        {
            //LoenguDemoEntities db = new LoenguDemoEntities();

            //var inimesed = db.Inimene.ToList();//.ToList();
            ////using(KonsoolEntity.LoenguDemoEntities )

            //foreach (var item in inimesed)
            //{
            //    Console.WriteLine(item.Eesnimi);
            //}

            using (LoenguDemoEntities db = new LoenguDemoEntities())
            {

                var inimesed = db.Inimene.ToList();//.ToList();
                                                   //using(KonsoolEntity.LoenguDemoEntities )

                foreach (var item in inimesed)
                {
                    Console.WriteLine(item.Eesnimi);
                }
            }
        }

        static void muudaAndmeid(int id, string eesnimi, string perenimi)
        {
            using (LoenguDemoEntities db = new LoenguDemoEntities())
            {
                var inimene = db.Inimene.Find(id);

                inimene.Eesnimi = eesnimi;
                inimene.Perenimi = perenimi;
                db.SaveChanges();

            }
        }

        static void kustutaInimene(int id)
        {
            using (LoenguDemoEntities db = new LoenguDemoEntities())
            {
                var inimene = db.Inimene.Where(x => x.InimeneID == id).FirstOrDefault();
                if (inimene != null)
                {
                    db.Inimene.Remove(inimene);
                    db.SaveChanges();
                }
            }
        }

        static void leiaNimeJargi(string nimi)
        {
            using (LoenguDemoEntities db = new LoenguDemoEntities())
            {

                var inimesed = db.Inimene.ToList();//.ToList();
                var inimesed2 = (from x in db.Inimene
                                 where x.Eesnimi.Contains(nimi) ||
                                       x.Perenimi.Contains(nimi)
                                 orderby x.Perenimi descending
                                 select x).ToList();

                var inimesed3 = db.Inimene.//.ToList().
                                Where(x => x.Eesnimi.Contains(nimi) ||
                                      x.Perenimi.Contains(nimi))
                                .OrderByDescending(x => x.Perenimi)
                                .Select(x => x)
                                .ToList();

                //using(KonsoolEntity.LoenguDemoEntities )

                foreach (var item in inimesed)
                {
                    Console.WriteLine(item.Eesnimi);
                }
            }

        }

        static void lisaInimene(string nimi, string perenimi)
        {
            using (LoenguDemoEntities db = new LoenguDemoEntities())
            {
                Inimene uusInimene = new Inimene()
                {
                    Eesnimi = nimi,
                    Perenimi = perenimi
                };
                db.Inimene.Add(uusInimene);
                db.SaveChanges();
                Console.WriteLine(uusInimene.InimeneID);

            }
        }

        static void leiaInimeneineIDJargi(int id)
        {
            using (LoenguDemoEntities db = new LoenguDemoEntities())
            {
                var inimene = db.Inimene.Where(x => x.InimeneID == id).FirstOrDefault();

                if (inimene != null)
                {
                    Console.WriteLine(inimene.Eesnimi);
                    foreach (var item in inimene.Kontakt)
                    {
                        Console.WriteLine(item.KontaktiTyyp.Nimi);
                        Console.WriteLine(item.Vaartus);
                    }




                }
            }
        }
    }
}
