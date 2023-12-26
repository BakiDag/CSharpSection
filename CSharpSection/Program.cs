using System;

namespace CSharpSection
{
    class Program
    {
        static int n1 = 432, n2 = 543;
        private static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            int addResult = Add(n1, n2);
            Console.WriteLine($"addResult: {addResult}");
            int substractResult = Substract(n1, n2);
            Console.WriteLine($"substractResult: {substractResult}");
            double multiplyResult = Multiply(n1, n2);
            Console.WriteLine($"multiplyResult: {multiplyResult}");
            float divideResult = Divide(n1, n2);
            Console.WriteLine($"divideResult: {divideResult}");
            Console.ReadKey();
        }

        private static int Add(int n1, int n2)
        {
            int result;
            result = n1 + n2;

            return result;
        }
        private static int Substract(int n1, int n2)
        {
            int result;
            result = n2 - n1;

            return result;
        }
        private static double Multiply(int n1, int n2)
        {
            int result;
            result = n1 * n2;

            return result;
        }
        private static float Divide(int n1, int n2)
        {
            
            float result = (float)n2 / (float)n1;

            return result;
        }
    }
}
