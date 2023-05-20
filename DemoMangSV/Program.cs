using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoMangSV
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            string[] sinhvien = {  "Thưởng", "Sáng", "Anh", "Hiếu", "Đạt" };

            // Array.Sort dùng để sắp xếp
            Array.Sort(sinhvien);
            //Array.Reverse dùng để đảo ngược mảng
            Array.Reverse(sinhvien);

            //foreach (string s in sinhvien)
            //{
            //    Console.WriteLine(s);
            //}

            for(int i = 0;i < sinhvien.Length;i++)
            {
                Console.WriteLine(sinhvien[i]);
            }

            Console.ReadLine();
        }
    }
}
