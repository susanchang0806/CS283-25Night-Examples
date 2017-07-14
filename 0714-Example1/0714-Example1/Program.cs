using System;

namespace _0714_Example1
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.Write("請輸入數字1:");
            int number1 = int.Parse(Console.ReadLine());
            Console.Write("請輸入數字2:");
            int number2 = int.Parse(Console.ReadLine());

            Console.WriteLine("{0}+{1}={2}"
                , number1
                , number2
                , number1 + number2);
        }
    }
}