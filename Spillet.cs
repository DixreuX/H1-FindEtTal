using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

// using static System.Console forkorter koden der har med konsollen at gøre. Console.Writeline(); bliver
// kun til Writeline(); og det er det samme med de andre konsol metoder. Readline();, Write();, Read();,
// Clear(); osv. 

namespace GætEtTal
{
    public class Spillet
    {
        // field/members
        public int randomNumber; // Det tilfældige tal
        public int guessedNumber; // Det seneste gættede tal
        public int possibleNumbers = 10; // Range for det tilfældige tal  
        //public string spilIgen;

        GUI GUI = new GUI();
        List<int> pickedNumbers = new List<int>(); // Liste a gættede tal i seneste session
        
        // Start metode
        public void StartSpillet()
        {
            GUI.VelkomstTekst(); // Intro tekst og formel
            GUI.BrugersModel(); // Viser brugeren deres model
            GUI.TrykENTERForAtStarte(); 
            ReadKey(); // Start trigger
            Clear();  // Rydder consolen for et clean display
            TilfældigtTal(); // Laver et tilfældigt tal
            GætEtTal(); // Selve Spillet
        }

        // Spillet
        public void GætEtTal()
        {
            while (true) // Kører indtil der gættes rigtigt og vi breaker.
            {        
                GUI.IndtastTal();
                guessedNumber = Convert.ToInt32(ReadLine());
                pickedNumbers.Add(guessedNumber);

                if (guessedNumber < randomNumber)
                {
                    Clear();
                    WriteLine("Gættede tal: " + String.Join(", ", pickedNumbers)); // Viser tidligere gættede tal
                    GUI.Lavt();               
                }
                else if (guessedNumber > randomNumber)
                {
                    Clear();
                    WriteLine("Gættede tal: " + String.Join(", ", pickedNumbers)); // Viser tidligere gættede tal
                    GUI.Højt();
                }
                else
                {
                    GUI.Rigtigt();
                    break;
                }
            }

            //SpilIgen();  
        }

        //public void SpilIgen()
        //{
        //    GUI.StartIgen();
        //    spilIgen = ReadLine();

        //    if (spilIgen == "ja")
        //    {
        //        Console.Clear();
        //        GætEtTal();
        //    }
        //    else if (spilIgen == "nej")
        //    {
        //        GUI.Farvel();
        //        Console.ReadKey();
        //        Environment.Exit(0);
        //    }
        //}

        // Tilfældig tal generator
        public void TilfældigtTal()
        {
            // Ny random klasse. Det nye tilfældige tal tilføjes til variblen randomNumber.
            Random rand = new Random();
            randomNumber = rand.Next(possibleNumbers) + 1;
        }
    }
}
