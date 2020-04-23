using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MinirechnerLatschrauner
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Geben sie Zahl 1 ein");
            int Zahl1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Geben sie Zahl 2 ein");
            int Zahl2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Summe = " + Addiere(Zahl1, Zahl2));
            Console.WriteLine("Differenzwert = " + Subtrahiere(Zahl1, Zahl2));
            Console.WriteLine("Produkt = " + Multipliziere(Zahl1, Zahl2));
            Console.WriteLine("Quozient = " + Dividiere(Zahl1, Zahl2));

            Console.ReadKey();

        }

        static int Addiere(int Zahl1, int Zahl2)
        {
            return (Zahl1 + Zahl2);
        
        }

        static int Subtrahiere(int Zahl1, int Zahl2)
    {

        return (Zahl1 - Zahl2);
    
    }
        static int Multipliziere(int Zahl1, int Zahl2)

        {

            return (Zahl1 * Zahl2);
        
        }


        static int Dividiere(int Zahl1, int Zahl2)

        {

            return (Zahl1 / Zahl2);
        
        }

    }

}
