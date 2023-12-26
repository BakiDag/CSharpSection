using System;

namespace CSharpSection
{
    class Program
    {
        static int n1 = 432, n2 = 543;
        private static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            var result = Add(n1, n2);
            
            Console.ReadKey();
        }

        private static int Add(int n1, int n2)
        {
            int result;
            result = n1 + n2;

            return result;
        }
    }
}
