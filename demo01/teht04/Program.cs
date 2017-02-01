using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace teht04
{
    class Program
    {
        static void Main(string[] args)
        {
            //Ask age
            int age;
            Console.WriteLine("Give your age > ");
            string line = Console.ReadLine();
            age = int.Parse(line);
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
