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
         //   leiaInimeneIdJargi(1);
            for (int i = 0; i < 10; i++)
            {
                lisaKontaktiTyyp("skype");
                
            }
        }

        static void lisaKontaktiTyyp(string nimi)
        {
            //nimi = nimi.ToLower();
            using (KontaktiRaamatEntities db = new KontaktiRaamatEntities())
            {
                var tyyp = db.KontaktiTyyp.Where(x => x.Nimi.ToLower()==nimi.ToLower()).FirstOrDefault();

                if (tyyp != null)
                {
                    return;
                }
                tyyp = new KontaktiTyyp()
                {
                    Nimi = nimi
                };
                db.KontaktiTyyp.Add(tyyp);
            } 
        }

            //using(PraktikumAB db = new PraktikumAB())
        static void lisaInimeseleKontaktAndmed(int inimeneId, int kontaktTyypId, string vaartus)
        {
            using (KontaktiRaamatEntities db = new KontaktiRaamatEntities())
            {
                Kontaktid kontakt = new Kontaktid()
                    InimeneId = inimeneId,
                    KontaktiTyypId = kontaktTyypId,
                    Vaartus = vaartus
            };
            
            {
                
            }
        }
            
        }
    }

