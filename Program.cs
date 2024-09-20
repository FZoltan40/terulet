using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace terulet
{
    internal class Program
    {
        static void terulet()
        {
            Console.WriteLine("Téglalap területének számítása.");

            int a;
            int b;
            int T;

            a = int.Parse(Console.ReadLine()); 
            b = int.Parse(Console.ReadLine());
            T = a * b;


        }
        static void Main(string[] args)
        {
            terulet ();
        }
    }
}
