using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace GætEtTal
{
    public class GUI
    {
        // GIU og brugerinformation

        Spilleren user = new Spilleren();

        public void VelkomstTekst()
        {
            WriteLine("Velkommen til spillet GÆT ET TAL\n\nProgrammet har valgt et tilfældigt tal som du skal gætte");
            WriteLine("Tallet er mellem 1 og 10\n\nIndtast dit navn, og tryk ENTER");
            user.navnPåSpiller = ReadLine();
            WriteLine("\nIndtast dit køn, og tryk ENTER");
            user.køn = ReadLine();
            WriteLine("\nIndtast din alder, og tryk ENTER");
            user.alder = Convert.ToInt32(ReadLine());
        }

        public void BrugersModel()
        {
            WriteLine("\nDine oplysninger er: " + user.navnPåSpiller + ", " + user.køn + ", " + user.alder + "\n\n");
        }

        public void Rigtigt()
        {
            WriteLine("\nDu gættede rigtigt!\n");
        }

        public void Højt()
        {
            WriteLine("\nDu gættede for højt");
        }

        public void Lavt()
        {
            WriteLine("\nDu gættede for lavt");
        }

        public void IndtastTal()
        {
            WriteLine("\nIndtast et tal:");
        }

        public void TrykENTERForAtStarte()
        {
            WriteLine("\nTryk ENTER for at starte");
        }
    }
}
