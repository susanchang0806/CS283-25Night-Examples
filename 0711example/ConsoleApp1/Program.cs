using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StudentMgtLibrary;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Student aStudent = new Student();
            Console.Write("請輸入學生姓名");
            aStudent.name = Console.ReadLine();
            Console.Write("請輸入學生電話");
            aStudent.phone = Console.ReadLine();
            Console.Write("請輸入學生地址");
            aStudent.address = Console.ReadLine();

            Console.WriteLine("學生姓名:{0}, 電話:{1}, 住址:{2}"
                , aStudent.name
                , aStudent.phone
                , aStudent.address
            );

        }
    }
}
