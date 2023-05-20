using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mang03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] songuyen = { 1, 4, 8, 9, 7, 2 };
            Console.WriteLine("Mang truoc sap xep");
            foreach (int song in songuyen)
            {
                Console.Write(song+"  ");
            }

            //Sắp xếp tăng dần
            Array.Sort(songuyen);

            Array.Reverse(songuyen);

            Console.WriteLine();
            Console.WriteLine("Mang sap xep giam dan");
            foreach (int song in songuyen)
            {
                Console.Write(song + "  ");
            }

            Console.ReadLine();


        }
    }
}
