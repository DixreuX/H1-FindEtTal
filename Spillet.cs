using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace GætEtTal
{
    public class Spillet
    {
        // field/members
        public int randomNumber; // Det tilfældige tal
        public int guessedNumber; // Det seneste gættede tal
        public int possibleNumbers = 10; // Range for det tilfældige tal  

        GUI GUI = new GUI();
        List<int> pickedNumbers = new List<int>(); // Liste a gættede tal i seneste session

        
        // Start metode
        public void StartSpillet()
        {
            //GUI.VelkomstTekst(); // Intro tekst og formel
            //GUI.BrugerInformation(); // Viser brugeren deres model
            GUI.TrykENTERForAtStarte();
            Console.ReadKey();
            Console.Clear(); 
            TilfældigtTal(); // Laver et tilfældigt tal
            GætEtTal(); // Selve Spillet
        }

        // Spillet
        public void GætEtTal()
        {
            while (true) // Kører indtil der gættes rigtigt og vi breaker.
            {
                WriteLine("Gættede tal: " + String.Join(", ", pickedNumbers));              
                GUI.IndtastTal();
                guessedNumber = Convert.ToInt32(ReadLine());
                pickedNumbers.Add(guessedNumber);

                if (guessedNumber < randomNumber)
                {
                    GUI.Lavt();               
                }
                else if (guessedNumber > randomNumber)
                {
                    GUI.Højt();
                }
                else
                {
                    GUI.Rigtigt();
                    break;
                }
            }
        }

        // Tilfældig tal generator
        public void TilfældigtTal()
        {
            // Ny random klasse. Det nye tilfældige tal tilføjes til variblen randomNumber.

            Random rand = new Random();
            randomNumber = rand.Next(possibleNumbers) + 1;
        }
    }
}
