using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace DemoArrayList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ArrayList songuyen = new ArrayList();
            songuyen.Add(3);
            songuyen.Add(4);
            songuyen.Add(5);
            songuyen.Add(7);

            int count = 0;
            foreach(int i in songuyen)
            {
                if (i %2 == 0)
                {
                    count++;
                }
            }

            Console.WriteLine("So phan tu chan:"+count);

            for(int i = 0; i < songuyen.Count;i++)
            {
                int x = Convert.ToInt32(songuyen[i].ToString());
                if (x %2 == 0)
                {
                    songuyen.RemoveAt(i);
                }
            }
            Console.WriteLine("Array List sau khi xoa so chan");
            for (int i = 0; i < songuyen.Count; i++)
            {
                Console.WriteLine(songuyen[i].ToString());
            }

            Console.ReadLine();
        }
    }
}
