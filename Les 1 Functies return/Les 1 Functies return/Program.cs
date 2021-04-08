using System;

namespace Les_1_Functies_return
{
    class Program
    {
        static void naam()
        {
            Console.WriteLine("Aidan Middel");
        }

        static string mijnNaam()
        {
            return "Aidan";
        }

        static void Main(string[] args)
        {
            string naam = mijnNaam();

            Console.WriteLine(naam);

        }
    }
}
