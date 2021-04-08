using System;

namespace csharples_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Divide(4, 0);
        }
        static void Divide(float a1, float a2)
        {
            float result = a1 / a2;
            Console.WriteLine("result = " + result);
        }
    }
}
