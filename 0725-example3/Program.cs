using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0725_example3
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            int[] numbers = new int[10];
            Random random = new Random();
            int sum = 0;

            for (int index = 0; index < numbers.Length; index++)
            {
                numbers[index] = random.Next(-1000, 1000);
                string numb = numbers[index] < 0 ? "(" + numbers[index].ToString() + ")" : numbers[index].ToString();
                sum += numbers[index];
                if (index == 0)
                {
                    Console.WriteLine("{0}", numb);
                }
                else
                {
                    Console.WriteLine("+{0}", numb);
                }
            }

            Console.WriteLine("={0}", sum);
        }
    }
}