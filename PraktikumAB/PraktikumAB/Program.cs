using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PraktikumAB
{
    class Program
    {
        static void Main(string[] args)
        {
            lisaBaasi("Peeter", "Pakiraam");
        }

        //          1) Loo meetod, mis kuvab inimesed andmebaasist

        static void kuvaInimesedAndmebaasist()
        {
            using (KontaktiRaamatEntities db = new KontaktiRaamatEntities())
            {
                var inimesed = (from x in db.Inimesed select x).ToList();
                var inimesed2 = db.Inimesed.ToList();
                foreach (var inimene in inimesed)
                {
                    Console.WriteLine(inimene.Eesnimi + " " + inimene.Perenimi);
                }
            }
        }
        //          2) Loo meetod, mis otsib inimesi eesnime järgi ja sorteerib tulemuse kasvavalt eesnime järgi

        static List<Inimesed> otsiEesnimeJärgi(string eesnimi)
        {
            using (KontaktiRaamatEntities db = new KontaktiRaamatEntities())
            {
                var inimesed = (from x in db.Inimesed
                                where x.Eesnimi.ToLower().Contains(eesnimi.ToLower())
                                orderby x.Eesnimi ascending
                                select x).ToList();

                //OrderBy - ascending
                //OrderByDescending - descending
                var inimesed2 = db.Inimesed.Where(x => x.Eesnimi.ToLower().Contains(eesnimi.ToLower()))
                    .OrderBy(x => x.Eesnimi).ToList();
                return inimesed;
            }
        }

        static void lisaBaasi(string eesnimi, string perenimi)
        {
            using (KontaktiRaamatEntities db = new KontaktiRaamatEntities())
            {
                Inimesed uusInimene = new Inimesed()
                {
                    Eesnimi = eesnimi,
                    Perenimi = perenimi
                };

                db.Inimesed.Add(uusInimene);

                db.SaveChanges();
            }
        }
        //          3) Loo meetod, mis võimaldab inimesi andmebaasi lisada

        //1) Loo meetod, mis võimaldab kontaktitüüpi andmebaasi lisada
    }
}
