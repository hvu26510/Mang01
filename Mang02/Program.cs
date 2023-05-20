using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mang02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Nhap so phan tu cua mang:");
            int sopt = int.Parse(Console.ReadLine());
            int[] songuyen = new int[sopt];

            for(int i = 0; i < songuyen.Length; i++)
            {
                Console.WriteLine($"Nhap phan tu thu {i+1}");
                songuyen[i] = int.Parse(Console.ReadLine());
            }

            int tong = 0;
            foreach(int i in songuyen)
            {
                tong = tong + i;
            }

            Console.WriteLine($"Tong = {tong}");

            Console.WriteLine($"Lap phuong cac phan tu");
            foreach (int i in songuyen)
            {
                Console.WriteLine($"{Math.Pow(i,3)}");
            }

            Console.ReadLine();
        }
    }
}
