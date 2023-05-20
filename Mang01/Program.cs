using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mang01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //khai báo 1 mảng int 6 phần tử, 
            // chưa khởi tạo giá trị
            //int[] mangInt = new int[6];

            // khai báo có khởi tạo
            int[] mangInt02 = { 1, 4, 7, 4, 7, 2 };

            int tong = 0;
            for (int i = mangInt02.Length-1; i >=0; i-- )
            {

                if (mangInt02[i] % 2 == 0)
                {
                    tong = tong + mangInt02[i];
                }
            }


            //foreach(int pt in mangInt02)
            //{
            //    Console.WriteLine(pt);
            //}

            Console.ReadLine();



        }
    }
}
