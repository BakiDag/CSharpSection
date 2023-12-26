using System;

namespace CSharpSection
{
    class Program
    {
        static float n1 = 432, n2 = 543;
        private static void Main(string[] args)
        {
            float addResult = Add();
            Console.WriteLine($"addResult: {addResult}");
            float substractResult = Substract();
            Console.WriteLine($"substractResult: {substractResult}");
            float multiplyResult = Multiply();
            Console.WriteLine($"multiplyResult: {multiplyResult}");
            float divideResult = Divide();
            Console.WriteLine($"divideResult: {divideResult}");
            Console.ReadKey();
        }

        private static float Add()
        {
            float result;
            result = n1 + n2;

            return result;
        }
        private static float Substract()
        {
            float result;
            result = n2 - n1;

            return result;
        }
        private static float Multiply()
        {
            float result;
            result = n1 * n2;

            return result;
        }
        private static float Divide()
        {
            
            float result = n2 / n1;

            return result;
        }
    }
}
