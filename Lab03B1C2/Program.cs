using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Lab03B1C2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ArrayList songuyen = new ArrayList();
            int count = 1;
            while (true)
            {
                Console.WriteLine("Nhap phan tu thu " + count);

                Console.WriteLine("Nhap 'q' de dung nhap ");
                string inPut = Console.ReadLine();
                if (inPut == "q")
                {
                    break;
                }
                else
                {
                    songuyen.Add(int.Parse(inPut));
                }
                count++;
            }
            // Sap xep
            songuyen.Sort();

            foreach (int i in songuyen)
            {
                Console.Write(i + " ");
            }

            songuyen.Reverse();

            Console.WriteLine();
            foreach (int i in songuyen)
            {
                Console.Write(i + " ");
            }

            Console.ReadLine();

        }
    }
}
