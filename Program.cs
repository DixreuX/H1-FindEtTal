using System;
using static System.Console;

namespace GætEtTal
{
    class Program
    {
        // Spillet: Gæt et tal mellem 1 og 10

        // To Do: Clean up display, Muligheden for at kører spillet igen eller lukke programmet. 

        static void Main(string[] args)
        {
            // Laver en et nyt Spillet objekt så StartSpil metoden kan kaldes
            Spillet SP = new Spillet();   
            SP.StartSpillet();
            ReadKey();
        }
    }
}
