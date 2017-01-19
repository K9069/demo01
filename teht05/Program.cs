using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace teht05
{
    class Program
    {
        static void Main(string[] args)
        {
            //Give seconds
            int number, sec, hour, min;
            
            Console.WriteLine("Give a number of seconds > ");
            string line = Console.ReadLine();
            number = int.Parse(line);

            min = (number % 3600) / 60;
            hour = number / 3600;
            sec = (number % 3600) % 60;

            Console.WriteLine("Hour "+ hour + " min " + min + " sec " + sec);

            Console.ReadLine();
        }
    }
}
