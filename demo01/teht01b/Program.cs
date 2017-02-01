using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace teht01b
{
    class Program
    {
        static void Main(string[] args)
        {
            //Ask number
            int number;
            Console.WriteLine("Give a number > ");
            string line = Console.ReadLine(); //"1"
            bool result = int.TryParse(line, out number); //"1" -> 1
            if (result == true)
            {
                // Wich number..
                switch (number)
                {
                    case 1: Console.WriteLine("One"); break;
                    case 2: Console.WriteLine("Two"); break;
                    case 3: Console.WriteLine("Three"); break;
                    default: Console.WriteLine("Some else number"); break;
                }
            }
            else
            {
                Console.WriteLine("Not a integer value!");
            }
            Console.ReadLine();
        }
    }
}
