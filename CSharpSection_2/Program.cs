using System;

namespace CSharpSection_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(SimpleMath.Division(432.23f, 5423.2f));
            Console.ReadKey();
        }
    }
    class SimpleMath
    {
        public static float Add(float n1,float n2)
        {
            return n1 + n2;
        }
        public static float Substract(float n1, float n2)
        {
            return n1 - n2;
        }
        public static float Multiplication(float n1, float n2)
        {
            return n1 * n2;
        }
        public static float Division(float n1, float n2)
        {
            return n1 / n2;
        }
    }
}
