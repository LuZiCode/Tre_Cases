using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicClass
{
    public class Fodbold
    {
        //Cheer = afleveringer, Celebrate = et mål
        //Opretter en public string (public betyder den kan tilgås fra andre classes), og finder ud om der skal handles med et mål eller afleveringer
        public string CheerOrCelebrate(string mål, int afleveringer)
        {
            //Opretter en var, som som er det sammen som handlingerne i IfGoal og printer stringen mål 
            var result_string = IfGoal(mål);

            //Hvis string ikke er 0 eller "" så udfør denne lykke
            if (!string.IsNullOrEmpty(result_string))
            {
                return result_string;
            }
            //Hvis den øverste ikke blev opfyldt
            else
            {
                //Så kører den videre til IfPasses (Ergo hvis intet mål er scoret)
                return IfPasses(afleveringer);
            }
        }

        //Hvis der var scoret et mål udfører den denne private string IfGoal (Private betyder, at den kun kan tilgås fra sammen class. Så brugeren skal være inde i denne-
        //fodbold class, før denne overhovede kan udføres.)
        private string IfGoal(string mål)
        {
            //Hvis der blive tastet "mål" ind ved kategorien mål, så udfører den denne handling (Hvis der er scoret et mål)
            //ToLower sørger for, at alt string, som bliver tastet ind bliver omskrevet til INGEN Caps (For at sikre computeren kan læse det, hvis folk skriver mål med storebogstaver)
            if (mål.ToLower() == "mål")
            {
                return "Olé Olé Olé Olé";
            }

            return string.Empty;
        }

        //Hvis der ingen mål er så kører denne her (se Linje 24-28)
        private string IfPasses(int afleveringer)
        {
            //Hvis aflevering er mindre end værdien 1 (Hvis der er 0), så kør det her
            if(afleveringer == 0 )
            {
                //Print Shh
                return "shh";           
            }
            
            //Eller hvis afleveringer er større end, eller ligmed 1 og mindre end 10, så kør denne her
            else if(afleveringer >= 1 && afleveringer < 10)
            {
                //Opretter en variable, som er blank
                var result = "";

                //Denne her lykke bliver gentaget indtil i ikke er mindre end afleveringer længere. Før første køring af lykken er i = 0, men hver gang den kører bliver i plusset-
                // med 0, så derfor bliver værdien ved med at blive større indtil i er større end afleveringer
                for(int i = 0; i < afleveringer; i++)
                {
                    //Denne her variable bliver printet hver gang for-lykken bliver fortaget. Så hvis der er 2 afleveringer bliver den printet 2 gange.
                    result += "Huh! ";
                }

                return result;
            }
            //Hvis intet ovenfor bliver overholdt kører den denne her i stedet (Hvis den er 10 eller over)
            else if (afleveringer >= 10)
            {
                return "High Five - Jubi";
            }
            else
            {
                return "Du har lavet en fejl";
            }
        }
    }
}
