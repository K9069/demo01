using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace teht10
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] luku = new int [9];
            int i;

            luku[0] = 1;
            luku[1] = 2;
            luku[2] = 33;
            luku[3] = 44;
            luku[4] = 55;
            luku[5] = 66;
            luku[6] = 77;
            luku[7] = 96;
            luku[8] = 100;

            for (i = 0; i < luku.Length; i++)
            {
                if (i % 2 == 0)
                {
                Console.WriteLine("HEP");
                }
            }
            Console.ReadLine();
        }
    }
}
