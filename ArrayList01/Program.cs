using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace ArrayList01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            ArrayList arl1 = new ArrayList();

            arl1.Add("Thưởng");
            arl1.Add(10);
            arl1.Add(true);

            Console.WriteLine(arl1[0]);
            Console.WriteLine(arl1[1]);
            Console.WriteLine(arl1[2]);

            Console.ReadLine();


        }
    }
}
