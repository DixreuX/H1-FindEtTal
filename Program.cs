using System;
using static System.Console;

namespace GætEtTal
{
    class Program
    {
        // Gæt et tal mellem 1 0g 10

        // To Do: Færdigør at vise gættede tal, Clean up display, Muligheden for at kører spillet igen eller lukke programmet. 

        static void Main(string[] args)
        {
            // Laver en et nyt Spillet objekt så StartSpil metoden kan kaldes

            Spillet SP = new Spillet();   

            SP.StartSpillet();
            ReadKey();
        }
    }
}
