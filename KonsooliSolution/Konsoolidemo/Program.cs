using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Konsoolidemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Tere! Maailm");
            Console.WriteLine("Tere, Tere!");   
            tyhi();
            string a = Console.ReadLine();
            Console.WriteLine(a);

            int b = int.Parse(a);
            Console.WriteLine(b);

            Console.ReadLine();
        }

        static void tyhi()
        {
            int a = 3;
            int b = 4;
            int c = 5;
        }
    }
}
