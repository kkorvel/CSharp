using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace praktikum2
{
    class Program
    {
        static void Main(string[] args)
        {
            //int a = kasutajaSisendToInt("Sisestage arv:");
           // int b = kasutajaSisendToInt("Sisestage teine arv:");
          //  int c = kasutajaSisendToInt("Minutekst!");
          //int tempFahren = kasutajaSisendToInt("Sisesta temperatuur Fahren!");
         // double tempKelvin = fahrenheitToKelvin(tempFahren);
           //onsole.WriteLine("temperatuur kelvinites on: "+tempKelvin);
            int tempCelsius = kasutajaSisendToInt("Sisesta celsius!");
            double tempFahren = celsiusToFahrenheit(tempCelsius);
            Console.WriteLine("Temperatuur fahren on:" + tempFahren);
        }

        //Mida peaks meetod tagastama?
        //Peaksime täisarvu tagastama
        //Mis võiks olla meetodi nimi?

        //kasutajaSisendToInt
        //Kas meetodil on vaja sisendparameetreid?
        //Jah, tekst mis kirjutatakse konsoolile.

        /// <summary>
        /// Küsib kasutajalt sisendi, kuni kasutaja kirjutab numbri
        /// </summary>
        /// <param name="tekst">Tekst, mis prinditakse ekraanile</param>
        /// <returns>Täisarvu kasutaja sisestatud tekstist</returns>
        static int kasutajaSisendToInt(String tekst)
        {
            Console.WriteLine(tekst);
            string tulemus = Console.ReadLine();

            int arv;
            if (int.TryParse(tulemus, out arv))
            {
                return arv;
            }
            else
            {
                return kasutajaSisendToInt("Viga! Palun sisestage uus number");
            }
        }
        //Luua meetod fahrenheitToKelvin, mis võtab sisendiks temperatuuri fahrenheitides ja tagastab selle Kelvinities
        //Mida peaks meetod tagastama?
        //peaksime tagastama double
        //Mis võiks olla meetodi nimi?

        //fahrenheittoKelvin
        //Kas meetodil on vaja sisendparameetreid?
        //Jah, temperatuur fahrenheitides.

        static double fahrenheitToKelvin(int tempFahren)

        {

            double tempKelvin = (tempFahren + 459.67)*5/9;
            return tempKelvin;
        }
        //Luua meetod celsiusToFahrenheit, mis võtab sisendiks temperatuuri kraadides ja tagastab fahrenheitides.
        //Mida peaks meetod tagastama?
        //peaksime tagastama double
        //Mis võiks olla meetodi nimi?

        //celsiusToFahrenheit
        //Kas meetodil on vaja sisendparameetreid?
        //Jah, temperatuur fahrenheitides.
        static double celsiusToFahrenheit(int tempCelsius)
        {
            var tempFahren = (tempCelsius + 9/5) + 32;
            return tempFahren;
        }
        //Luua meetod, mis küsib kasutajalt vanust ning tagastab, kas tegemist on täisealise kasutajaga
        //Mida peaks meetod tagastama?
        //peaksime tagastama bool
        //Mis võiks olla meetodi nimi?

        //kasOnTaisEaline
        //Kas meetodil on vaja sisendparameetreid?
        //Jah, kasutaja vanust

        static bool kasOnTaisEaline(int vanus)
        {
            return vanus > 17;
        }
        //Mida peaks meetod tagastama?
        //ja tagastab kas on kolmnurk
        //Mis võiks olla meetodi nimi?

        //booleani
        //Kas meetodil on vaja sisendparameetreid?
        //jah, kolme külje pikkused
        static bool kasOnKolmnurk(int a, int b, int c)
        {
            // || on or ja && on and
            if (a + b > c && c + b > a && a + c > b)
            {
                return true;
            

            }
            return false;
        }
    }

}
