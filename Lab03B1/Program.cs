using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab03B1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("So phan tu cua mang:");
            int sopt = int.Parse(Console.ReadLine());

            int[] songuyen = new int[sopt];
            //Nhập phần tử
            for (int i = 0; i < songuyen.Length; i++)
            {
                Console.WriteLine($"Nhap phan tu so: {i + 1}");
                songuyen[i] = int.Parse(Console.ReadLine());
            }

            //tăng dần
            Array.Sort(songuyen);
            Console.WriteLine($"Sap xep tang dan");
            foreach (int pt in songuyen)
            {
                Console.Write(pt + "  ");
            }

            //giảm dần(đảo ngược của tăng dần)
            Array.Reverse(songuyen);
            Console.WriteLine();
            Console.WriteLine($"Sap xep giam dan");
            foreach (int pt in songuyen)
            {
                Console.Write(pt + "  ");
            }

            // Xuat min
            Console.WriteLine("Min = " + songuyen[songuyen.Length - 1]);

            //Tính TBC
            int tong = 0, count = 0;
            foreach (int pt in songuyen)
            {
                if (pt % 3 == 0)
                {
                    tong = tong + pt;
                    count++;
                }
            }
            Console.WriteLine($"TBC = {tong*1.0/count}");
            Console.ReadLine();
        }
    }
}
