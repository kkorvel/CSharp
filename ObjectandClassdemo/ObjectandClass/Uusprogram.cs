using System;

namespace ObjectandClass
{
    public class Uusprogram
    {
        static void Main(string[] args)
        {
            Ristkylik uusRistkylik = new Ristkylik(2,3);
            Ristkylik teineRistkylik = new Ristkylik(5,6);

            int vastus = uusRistkylik.Ymberm66T();
            Console.WriteLine(vastus);

            bool uuem = uusRistkylik.kasOnVordsed(teineRistkylik);
            Console.WriteLine(uuem);

            int uusvastus = teineRistkylik.Ymberm66T();
            Console.WriteLine(uusvastus);

            bool uusuuem = teineRistkylik.kasOnVordsed(uusRistkylik);
            Console.WriteLine(uusuuem);

        }
    }
}