using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Praktikum04
{
    class Program
    {
        static void Main(string[] args)
        {
            Mootorsoiduk soiduk = new Mootorsoiduk(60);
            soiduk.Kiirenda();
            soiduk.Kiirenda();
            Console.WriteLine(soiduk);
            soiduk.Stop();
            Console.WriteLine(soiduk);

            Auto uusAuto = new Auto();
        }
    }
}
