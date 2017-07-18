using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0718_example_math
{
    internal class Person
    {
        public string Name;
        public Position Pos;
        public double Angle;

        public void MoveForward(double d)
        {
            Pos.x = Pos.x + d * Math.Cos(Angle * Math.PI / 180.0);
            Pos.y = Pos.y + d * Math.Sin(Angle * Math.PI / 180.0);
            WriteLine();
        }

        public void TurnRight(double angle)
        {
            Angle = (Angle + angle) % 360.0;
            WriteLine();
        }

        public void WriteLine()
        {
            Console.WriteLine("{0}的位置在({1}, {2}), 方位角:{3}度", Name, Pos.x, Pos.y, Angle);
        }

        public void DrawSquare(int length, int angle)
        {
            for (var count = 0; count < 4; count++)
            {
                MoveForward(length);
                TurnRight(angle);
            }
        }
    }
}