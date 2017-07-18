using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0718_example_math
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Person elsa = new Person()
            {
                Name = "ELSA",
                Pos = new Position()
                {
                    x = 50,
                    y = 50,
                },
                Angle = 0
            };

            elsa.DrawSquare(50, 90);
        }
    }
}