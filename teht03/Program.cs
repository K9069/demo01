using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace teht03
{
    class Program
    {
        static void Main(string[] args)
        {
            //Ask 3 numbers
            int number1, number2, number3;
            Console.WriteLine("Give number > ");
            string line = Console.ReadLine(); 
            number1 = int.Parse(line);
            Console.WriteLine("Give number > ");
            string line1 = Console.ReadLine(); 
            number2 = int.Parse(line1);
            Console.WriteLine("Give number > ");
            string line2 = Console.ReadLine(); 
            number3 = int.Parse(line2);
            // Paste numbers and average
            Console.WriteLine( number1 + number2 + number3);
            Console.WriteLine((number1 + number2 + number3) / 3);

            Console.ReadLine();
        }
    }
}
