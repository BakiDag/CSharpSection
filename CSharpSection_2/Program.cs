﻿using System;
using CSharpSection_2.Classes;

namespace CSharpSection_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(SimpleMath.Division(432.23f, 5423.2f));
            BankAccount bankAccount1 = new BankAccount(124321.32f, "Jane Doe");
            Console.WriteLine(bankAccount1.Balance);
            BankAccount bankAccount2 = new BankAccount(1321.43f, "John Doe");

            Console.WriteLine(bankAccount1.AddBalance(100f));
            Console.WriteLine(bankAccount2.AddBalance(-1421.43f, true));

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
