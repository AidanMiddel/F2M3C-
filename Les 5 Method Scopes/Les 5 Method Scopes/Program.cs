using System;

namespace Les_5_Method_Scopes
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }

        public static void scope(string[] args)
        {
            if (true)
            {
                // Scope line 8: If Statement & Alles er buiten
                string scope8Var = "8";

                if (true)
                {
                    // Scope line 12: If Statement & Alles er buiten
                    string scope12Var = "12";
                }

                if (false)
                {
                    // Scope line 17: If Statement & Alles er buiten    
                    string scope17Var = "17";
                }

                Console.WriteLine("This was set in scope line 8: " + scope8Var);
                Console.WriteLine("This was set in scope line 12: " + scope12Var);
                Console.WriteLine("This was set in scope line 17: " + scope17Var);
            }
        }
    }
}
