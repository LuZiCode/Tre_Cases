using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tre_Cases
{
    internal class Program
    {

        internal void Run()
        {  


            Console.WriteLine("|Navigations Menu|");
            Console.WriteLine("Hvor vil du gerne navigere hen?");
            Console.WriteLine("");
            Console.WriteLine("1 - Fodbold");
            Console.WriteLine("2 - Dans");
            Console.WriteLine("");
            Console.Write("Indtast dit svar: ");
            var input = Console.ReadLine();

            //Hvis brugeren skriver fodbold, så kør denne her
            if (input.ToLower() == "fodbold" || input == "1")
            {
                //går ind i foldbold og åbner den
                var f = new Fodbold();
                f.Run();
            }
            //Hvis brugeren skriver dans, så kør denne her
            else if (input.ToLower() == "dans" || input == "2")
            {
                //går ind i dans og åbner den
                var d = new Dans();
                d.Run();
            }
            else
            {
                Console.WriteLine("Der er opstået en fejl. Tryk Enter for at fortsætte");

            }
            Console.ReadKey();
            Console.Clear();
            
        }

    }
}
