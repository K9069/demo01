using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace teht08
{
    class Program
    {
        static void Main(string[] args)
        {
            //Ask number
            int number, number1, number2, luku;
            Console.WriteLine("Give a number > ");
            string line = Console.ReadLine();
            number = int.Parse(line);

            Console.WriteLine("Give a second number > ");
            string line1 = Console.ReadLine();
            number1 = int.Parse(line1);

            Console.WriteLine("Give a third number > ");
            string line2 = Console.ReadLine();
            number2 = int.Parse(line2);
            
            if (number1 > number)
            {
                luku = number1;
                number = number1;
                number1 = luku;
            }

            if (number2 > number1)
            {
                luku = number2;
                number1 = number2;
                number2 = luku;
            }
            if (number1 > number)
            {
                luku = number1;
                number = number1;
                number1 = luku;
            }
            Console.WriteLine("Suurin luku on " + number);


            Console.ReadLine();
        }
    }
}
