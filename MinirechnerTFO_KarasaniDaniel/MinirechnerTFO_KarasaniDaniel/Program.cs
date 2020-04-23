using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MinirechnerTFO_KarasaniDaniel
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Zahl1: ");
            int Zahl1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Zahl2: ");
            int Zahl2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("\n1.Zahl: "+Zahl1+"\n2.Zahl: "+Zahl2);

            Console.ReadKey();
        }
    }
}
