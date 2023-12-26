using System;

namespace CSharpSection
{
    class Program
    {
        static int n1 = 432, n2 = 543;
        private static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            int addResult = Add();
            Console.WriteLine($"addResult: {addResult}");
            int substractResult = Substract();
            Console.WriteLine($"substractResult: {substractResult}");
            double multiplyResult = Multiply();
            Console.WriteLine($"multiplyResult: {multiplyResult}");
            float divideResult = Divide();
            Console.WriteLine($"divideResult: {divideResult}");
            Console.ReadKey();
        }

        private static int Add()
        {
            int result;
            result = n1 + n2;

            return result;
        }
        private static int Substract()
        {
            int result;
            result = n2 - n1;

            return result;
        }
        private static double Multiply()
        {
            int result;
            result = n1 * n2;

            return result;
        }
        private static float Divide()
        {
            
            float result = (float)n2 / (float)n1;

            return result;
        }
    }
}
