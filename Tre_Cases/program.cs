using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Text.RegularExpressions;

namespace Tre_Cases
{
    internal class Adgangskode
    {
        static void Main(string[] args)
        {
            Boolean accepterellerik = false;
            while (accepterellerik == false)
            {


                Console.Clear();
                Console.WriteLine("Velkommen til Tre_Cases Login Menu");
                Console.WriteLine("");
                Console.WriteLine("1 - Login");
                Console.WriteLine("2 - Skift adgangskode");
                Console.WriteLine("3 - Opret bruger");
                Console.WriteLine("");
                Console.Write("Indtas din ønskede mulighed: ");

                var mulighed = Convert.ToChar(Console.ReadLine().ToLower());


                switch (mulighed)
                {
                    case '1':
                        string brugernavn;
                        string adgangskode;
                        Console.Clear();
                        Console.WriteLine("Login til eksisterende bruger");
                        Console.WriteLine("");
                        Console.Write("Indtast brugernavn: ");
                        brugernavn = Console.ReadLine();
                        Console.Write("Indtast adgangskode: ");
                        adgangskode = Console.ReadLine();

                        string filePathBrugernavn = @"C:\Users\luczie\Desktop\The Three Cases - CSharp\Tre_Cases\Data\brugernavn.txt";
                        string filePathAdgangskode = @"C:\Users\luczie\Desktop\The Three Cases - CSharp\Tre_Cases\Data\adgangskode.txt";

                        if (File.ReadAllLines(filePathBrugernavn).Contains(brugernavn) && File.ReadAllLines(filePathAdgangskode).Contains(adgangskode))
                        {
                            Console.Clear();
                            Console.WriteLine("Du er nu logget ind");
                            Console.WriteLine("Tryk Enter for at navigere ind i hovedmenuen");
                            accepterellerik = true;
                            Console.ReadKey();
                        }
                        else
                        {
                            Console.WriteLine("");
                            Console.WriteLine("Brugernavnet eller adgangskoden er forkert!");
                            Console.WriteLine("Tryk Enter for at prøve igen");
                            Console.ReadKey();
                        }
                        break;
                    case '2':
                        Console.Clear();
                        Console.WriteLine("Ændre din adgangskode");
                        Console.WriteLine("");
                        Console.WriteLine("Login til eksisterende bruger for at ændre adgangskode");
                        Console.WriteLine("");
                        Console.Write("Indtast brugernavn: ");
                        brugernavn = Console.ReadLine();
                        Console.Write("Indtast adgangskode: ");
                        adgangskode = Console.ReadLine();

                        filePathBrugernavn = @"C:\Users\luczie\Desktop\The Three Cases - CSharp\Tre_Cases\Data\brugernavn.txt"; filePathAdgangskode = @"C:\Users\luczie\Desktop\The Three Cases - CSharp\Tre_Cases\Data\adgangskode.txt";

                        if (File.ReadAllLines(filePathBrugernavn).Contains(brugernavn) && File.ReadAllLines(filePathAdgangskode).Contains(adgangskode))
                        {
                            Boolean ChangePass = false;
                            while (ChangePass == false)
                            {
                                Console.Clear();
                                Console.Write("Skriv din nye adgangskode for at ændre den: ");
                                string newpass = Console.ReadLine();
                                Console.Write("Gentag din nye adgangskode: ");
                                string newpass2 = Console.ReadLine();

                                if (newpass == newpass2)
                                {
                                    File.WriteAllText(filePathAdgangskode, newpass2);
                                    Console.WriteLine("Du har nu ændret kodeordet");
                                    ChangePass = true;
                                }
                                else
                                {
                                    Console.Clear();
                                    Console.WriteLine("Koden matcher ikke");
                                    Console.WriteLine("Tryk Enter for at prøve igen");
                                    Console.ReadKey();
                                }
                            }
                            Console.ReadKey();
                        }
                        else
                        {
                            Console.WriteLine("");
                            Console.WriteLine("Brugernavnet eller adgangskoden er forkert!");
                            Console.WriteLine("Tryk Enter for at prøve igen");
                            Console.ReadKey();
                        }
                        break;
                    case '3':
                        Boolean adgangskodekrav = false;
                        while (adgangskodekrav == false)
                        {
                            Console.Clear();
                            Console.WriteLine("Opret en ny bruger:");
                            Console.WriteLine("");
                            Console.Write("Indtast brugernavn: ");
                            brugernavn = Console.ReadLine();
                            Console.WriteLine();
                            Console.Write("Indtast adgangskode: ");
                            adgangskode = Console.ReadLine();
                            Console.WriteLine("");

                            if (brugernavn != null && adgangskode.Length >= 12)
                            {
                                adgangskodekrav = true;
                                string adgangskode2 = "";
                                while (adgangskode != adgangskode2)
                                {
                                    Console.Write("Gentast adgangskode: ");
                                    adgangskode2 = Console.ReadLine();

                                    if (adgangskode == adgangskode2)
                                    {
                                        filePathBrugernavn = @"C:\Users\luczie\Desktop\The Three Cases - CSharp\Tre_Cases\Data\brugernavn.txt"; filePathAdgangskode = @"C:\Users\luczie\Desktop\The Three Cases - CSharp\Tre_Cases\Data\adgangskode.txt";
                                        File.WriteAllText(filePathAdgangskode, adgangskode);
                                        File.WriteAllText(filePathBrugernavn, brugernavn);




                                        Console.Clear();
                                        Console.WriteLine("Du har nu oprettet en ny bruger!");
                                        Console.WriteLine("Tryk Enter for, at navigere tilbage til login menuen");
                                        Console.ReadKey();
                                    }
                                    else
                                    {
                                        Console.WriteLine("");
                                        Console.WriteLine("Adgangskodenerne matcher ikke");
                                        Console.WriteLine("Tryk enter for at prøve igen");
                                        Console.ReadKey();
                                    }
                                }

                            }
                            else
                            {
                                Console.WriteLine("");
                                Console.WriteLine("Du har ikke opfyldt kravene til at oprette en ny bruger!");
                                Console.WriteLine("");
                                Console.WriteLine("Dit brugernavn må ikke være tomt");
                                Console.WriteLine("Din adgangskode skal minimun være 12 karakterer lang");
                                Console.WriteLine("Din adgangskode skal minimun indebære 2 speciale karakterer");

                                Console.ReadKey();
                            }
                        }
                        break;

                    default:
                        Console.Clear();
                        Console.WriteLine("Der er opstået en fejl");
                        Console.WriteLine(" Tryk Enter for at prøve igen");
                        Console.ReadKey();
                        break;
                }

            }

            Console.Clear();
            var program = new Program();
            program.Run();
        }
    }

    public class Program
    { 
        internal void Run()
        {
            Boolean gåvidereellerik = false;

            while(gåvidereellerik == false)
            {
            Console.Clear();
            Console.WriteLine("|Navigations Menu|");
            Console.WriteLine("");
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
}
