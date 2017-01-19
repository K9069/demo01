using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teht01
{
    class Program
    {
        static void Main(string[] args)
        {
            //Ask number
            int number;
            Console.WriteLine("Give a number > ");
            string line = Console.ReadLine(); //"1"
            number = int.Parse(line); //"1" -> 1
            // Wich number..
            switch (number)
            {
                case 1: Console.WriteLine("One"); break;
                case 2: Console.WriteLine("Two"); break;
                case 3: Console.WriteLine("Three"); break;
                default: Console.WriteLine("Some else number"); break;
            }
            Console.ReadLine();
        }
    }
}
