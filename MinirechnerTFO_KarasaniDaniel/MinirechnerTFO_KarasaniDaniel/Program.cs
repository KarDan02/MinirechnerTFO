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
            Console.Write("1.Zahl: ");
            int Zahl1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("2.Zahl: ");
            int Zahl2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Summe: "+Addiere(Zahl1, Zahl2));

            Console.ReadKey();
        }

        static int Addiere(int Zahl1, int Zahl2)
        { 
        return (Zahl1+Zahl2);
        }
    }
}
