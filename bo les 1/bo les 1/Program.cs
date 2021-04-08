using System;

namespace bo_les_1
{
    class Program
    {
        static void Main(string[] args)
        {
            //variablene in camelCase
            float   mijnCommaGetal      = 10.5f;
            int     mijnHeleGetal       = 1;
            string  mijnWoord           = "Met Quotes";
            bool    mijnWoorofNietWaar  = true;
            bool    mijnNietWaarofWaar  = false;
            double  mijnCommaDouble     = 10.0d;

            //plus elkaar
            float hetAntwoord = Plus(10, 10);
            Console.WriteLine(hetAntwoord);

            //min elkaar
            float minElkaar = Min(5, 10);
            Console.WriteLine(minElkaar);

            //keer elkaar
            float keerElkaar = Keer(8, 8);
            Console.WriteLine(keerElkaar);

            //gedeeld door elkaar
            float delenDoor = Deel(20, 5);
            Console.WriteLine(delenDoor);

            Plus(10, 10);

            //Console.WriteLine("Hello World!");
        }
        //toegankelijkheid, return typ, functie naam, argumenten en scope
        public static float Plus(float eersteGetal, float tweedeGetal)
        {
            return eersteGetal + tweedeGetal;
        }

        public static float Keer(float eersteGetal, float tweedeGetal)
        {
            return eersteGetal * tweedeGetal;
        }

        public static float Min(float eersteGetal, float tweedeGetal)
        {
            return eersteGetal - tweedeGetal;
        }

        public static float Deel(float eersteGetal, float tweedeGetal)
        {
            return eersteGetal / tweedeGetal;
        }
    }
}
