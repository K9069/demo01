using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace teht06
{
    class Program
    {
        static void Main(string[] args)
        {
            //Ask distance
            int distance;
            Console.WriteLine("Give your distance > ");
            string line = Console.ReadLine();
            distance = int.Parse(line);
            //Determinate age
            if (age < 18)
            {
                Console.WriteLine("Alaikäinen");
            }
            else if (age >= 18 && age <= 65)
            {
                Console.WriteLine("Aikuinen");
            }
            else
            {
                Console.WriteLine("Seniori");
            }
            Console.ReadLine();
        }
    }
}