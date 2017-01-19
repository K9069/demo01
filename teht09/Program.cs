using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace teht09
{
    class Program
    {
        static void Main(string[] args)
        {
            int luku, summa = 0;

            //Console.WriteLine("Anna luku >");
            //string line = Console.ReadLine();
            //luku = int.Parse(line);

            do
            {

                
                Console.WriteLine("Anna luku >");
                string line = Console.ReadLine();
                luku = int.Parse(line);
                summa = summa + luku;

            } while (luku != 0);
            Console.WriteLine("Summa on " + summa);
            Console.ReadLine();
        }
    }
}
