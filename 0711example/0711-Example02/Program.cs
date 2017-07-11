using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StudentMgtLibrary;

namespace _0711_Example02
{
    class Program
    {
        static void Main(string[] args)
        {
            Student aStudent = new Student()
            {
                name = "Susan",
                phone = "0987656544",
                address = "Taipei, Taiwan"

            };

            Console.WriteLine("學生姓名:{0}, 電話:{1}, 住址:{2}"
                    , aStudent.name
                    , aStudent.phone
                    , aStudent.address
                );

        }
    }
}
