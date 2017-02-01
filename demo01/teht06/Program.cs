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
            double kulutus = 0.0702, bensa = 1.595, matka, kulut, euro;
            //Ask distance       
            Console.WriteLine("Anna matka kilometreinä > ");
            string line = Console.ReadLine();
            matka = int.Parse(line);

            kulut = matka * kulutus;
            euro = kulut * bensa;

            Console.WriteLine("Bensaa kuluu " + kulut + "litraa, kustannus " + euro + " euroa.");
            Console.ReadLine();
        }
    }
}