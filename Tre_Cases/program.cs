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
            //Opretter en ny boolean, som er falsk
            Boolean accepterellerik = false;
            //opretter en Whilelykke, som kører hver gang booleanen er false (Hvilket den er indtil den bliver true)
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

                //Converter min var til char, så jeg kan køre en switch case
                var mulighed = Convert.ToChar(Console.ReadLine().ToLower());

                //Opretter en switchcase, som håndterer muligheds input
                switch (mulighed)
                {
                    //Kører denne case, hvis input i mulighed er "1"
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

                        //Opretter en ny string, som håndterer txt filen "brugernavn.txt". "@" foran linket til filerne fortæller computeren at de specialle tegn ikke er en del af teksten
                        string filePathBrugernavn = @"C:\Users\luczie\Desktop\The Three Cases - CSharp\Tre_Cases\Data\brugernavn.txt";
                        //Opretter en ny string, som håndterer txt filen "adgangskode.txt"
                        string filePathAdgangskode = @"C:\Users\luczie\Desktop\The Three Cases - CSharp\Tre_Cases\Data\adgangskode.txt";

                        //Læs alle linjer fra stringen filePathbrugernavn, hvis den indebærer input fra brugernavn og alle linjer fra stringen FilePathAdgangskode indebærer-
                        //input fra adgangskode, så kør denne if sætning
                        if (File.ReadAllLines(filePathBrugernavn).Contains(brugernavn) && File.ReadAllLines(filePathAdgangskode).Contains(adgangskode))
                        {
                            Console.Clear();
                            Console.WriteLine("Du er nu logget ind");
                            Console.WriteLine("Tryk Enter for at navigere ind i hovedmenuen");
                            //Laver min boolean (som jeg navngav oppe i toppen af password programmet) til true, så den bryder ud af lykken
                            accepterellerik = true;
                            Console.ReadKey();
                        }
                        //Hvis tilfældet er, at brugernavnet eller adgangskoden ikke passer til deres txt filer, så kør denne her
                        else
                        {
                            Console.WriteLine("");
                            Console.WriteLine("Brugernavnet eller adgangskoden er forkert!");
                            Console.WriteLine("Tryk Enter for at prøve igen");
                            //Man ryger selfølgelig tilbage til main programmet, fordi "accepterellerik" stadig ikke er true, så lykken brydes ikke
                            Console.ReadKey();
                        }
                        break;
                    //Kører denne case, hvis input i mulighed er "1"
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

                        //Opretter en ny string, som håndterer txt filen "brugernavn.txt", og opretter en ny string, som håndterer txt filen "adgangskode.txt"
                        filePathBrugernavn = @"C:\Users\luczie\Desktop\The Three Cases - CSharp\Tre_Cases\Data\brugernavn.txt"; filePathAdgangskode = @"C:\Users\luczie\Desktop\The Three Cases - CSharp\Tre_Cases\Data\adgangskode.txt";

                        //Læs alle linjer fra stringen filePathbrugernavn, hvis den indebærer input fra brugernavn og alle linjer fra stringen FilePathAdgangskode indebærer-
                        //input fra adgangskode, så kør denne if sætning
                        if (File.ReadAllLines(filePathBrugernavn).Contains(brugernavn) && File.ReadAllLines(filePathAdgangskode).Contains(adgangskode))
                        {
                            //Opretter en ny boolean, som er falsk
                            Boolean ChangePassKrav = false;
                            //opretter en Whilelykke, som kører hver gang booleanen er false (Hvilket den er indtil den bliver true)
                            while (ChangePassKrav == false)
                            {
                                Console.Clear();
                                Console.Write("Skriv din nye adgangskode for at ændre den: ");
                                //Opretter en ny string, som håndterer det nye password
                                string newpass = Console.ReadLine();

                                //Opretter en et nyt Object, som åbner klassen Password_Logic.cs
                                LogicClass.Password_Logic tjekefterkrav_Object = new LogicClass.Password_Logic();
                                //Opretter en ny int, som er går ind i min public string "HasSpecialChar" med værdien fra stringen newpass
                                int hasSpecialChar = tjekefterkrav_Object.HasSpecialChar(newpass);
                                //Opretter en ny int, som er går ind i min public string "HasNumber" med værdien fra stringen newpass
                                int hasNumber = tjekefterkrav_Object.HasNumber(newpass);
                                //Opretter en ny int, som er går ind i min public string "HasCapital " med værdien fra stringen newpass
                                int hasCapital = tjekefterkrav_Object.HasCapital(newpass);

                                //Hvis hasSpecialChar opfyldes mere end 1 gang, og hvis hasNumber opfyldes mere end 1 gang, og hvis hasCapital opfyldes mere end 1 gang, så kør denne if sætning
                                if (hasSpecialChar > 1 && hasNumber > 1 && hasCapital > 1)
                                {
                                    //Laver ChangePassKrav til true, så den bryder ud af loopen
                                    ChangePassKrav = true;
                                    Console.WriteLine("");
                                    Console.Write("Gentag din nye adgangskode: ");
                                    //Laver en ny string, som håndterer gentagelse af den nye kode
                                    string newpass2 = Console.ReadLine();
                                    //Laver en ny bool, som er falsk
                                    Boolean ChangePass = false;
                                    //Laver en ny whileloop, kører så længe ChangePass er false (Hvilket den er indtil den bliver true)
                                    while (ChangePass == false)
                                    {
                                    //Hvis newpass er det samme som newpass2, så kør denne
                                    if(newpass == newpass2)
                                    {
                                        //Skriv alt tekst fra stringen newpass2 ind i filePathAdgangskode og overskriv alt derinde.  
                                        File.WriteAllText(filePathAdgangskode, newpass2);
                                        Console.WriteLine("Du har nu ændret kodeordet");
                                        //Laver changepass til true, så man bryder ud af loopen
                                        ChangePass = true;
                                    }
                                    //Hvis newpass ikke er det samme som newpass2, så kør denne her
                                    else
                                    {
                                        Console.WriteLine("");
                                        Console.WriteLine("Adgangskoden matcher ikke!");
                                        Console.WriteLine("Tryk Enter for at prøve igen");
                                        Console.ReadKey();
                                    }
                                    }
                                }
                                //Kør denne hvis kravene fra hasSpecialChar, hasNumber og hasCapital ikke opfyldes
                                else
                                {
                                    Console.Clear();
                                    Console.WriteLine("Koden matcher ikke kodeoprettelses kravene");
                                    Console.WriteLine("Tryk Enter for at prøve igen");
                                    Console.ReadKey();
                                }
                            }
                            Console.ReadKey();
                        }
                        //Hvis adgangskoden ikke opfylder stringen filePathadgangskode eller hvis brugernavnet ikke opfylder stringen filePathBrugernavn
                        else
                        {
                            Console.WriteLine("");
                            Console.WriteLine("Brugernavnet eller adgangskoden er forkert!");
                            Console.WriteLine("Tryk Enter for at vende tilbage");
                            Console.ReadKey();
                        }
                        break;
                    //Kører denne case, hvis input i mulighed er "1"
                    case '3':
                        //Opretter en Boolean, som er falsk
                        Boolean adgangskodekrav = false;
                        //opretter en Whilelykke, som kører hver gang booleanen er false (Hvilket den er indtil den bliver true)
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
                            //Opretter en et nyt Object, som åbner klassen Password_Logic.cs
                            LogicClass.Password_Logic tjekefterkrav_Object = new LogicClass.Password_Logic();
                            //Opretter en ny int, som er går ind i min public string "HasSpecialChar" med værdien fra stringen newpass
                            int hasSpecialChar = tjekefterkrav_Object.HasSpecialChar(adgangskode);
                            //Opretter en ny int, som er går ind i min public string "HasNumber" med værdien fra stringen newpass
                            int hasNumber = tjekefterkrav_Object.HasNumber(adgangskode);
                            //Opretter en ny int, som er går ind i min public string "HasCapital" med værdien fra stringen newpass
                            int hasCapital = tjekefterkrav_Object.HasCapital(adgangskode);


                            //Læs alle linjer fra stringen filePathbrugernavn, hvis den indebærer input fra brugernavn og alle linjer fra stringen FilePathAdgangskode indebærer-
                            //input fra adgangskode, så kør denne if sætning
                            if (brugernavn != null && adgangskode.Length >= 12 && hasSpecialChar > 1 && hasNumber > 1 && hasCapital > 1)
                            {
                                //Laver adgangskodekrav til true, så man bryder ud af loopen
                                adgangskodekrav = true;
                                string adgangskode2 = "";
                                //Laver en while loop som kører hvis adgangskode ikke er den samme som adgangskode2 
                                while (adgangskode != adgangskode2)
                                {
                                    Console.Write("Gentast adgangskode: ");
                                    adgangskode2 = Console.ReadLine();
                                    
                                    //Kør denne her, hvis adgangskode er det samme som adgangskode2
                                    if (adgangskode == adgangskode2)
                                    {
                                        //Opretter en string, som indebærer tekstfilen "brugernavn.txt" og opretter en string, som indebærer tekstfilen "adgangskode.txt"
                                        filePathBrugernavn = @"C:\Users\luczie\Desktop\The Three Cases - CSharp\Tre_Cases\Data\brugernavn.txt"; filePathAdgangskode = @"C:\Users\luczie\Desktop\The Three Cases - CSharp\Tre_Cases\Data\adgangskode.txt";
                                        //Skriver alt tekst fra adgangskode ind i og erstatter teskten i stringen filePathAdgangskode 
                                        File.WriteAllText(filePathAdgangskode, adgangskode);
                                        //Skriver alt tekst fra adgangskode ind i og erstatter teskten i stringen filePathAdgangskode 
                                        File.WriteAllText(filePathBrugernavn, brugernavn);

                                        Console.Clear();
                                        Console.WriteLine("Du har nu oprettet en ny bruger!");
                                        Console.WriteLine("Tryk Enter for, at navigere tilbage til login menuen");
                                        Console.ReadKey();
                                    }
                                    //Hvis adgangskode ikke er det samme som adgangskode2, så kør denne her.
                                    else
                                    {
                                        Console.WriteLine("");
                                        Console.WriteLine("Adgangskodenerne matcher ikke");
                                        Console.WriteLine("Tryk enter for at prøve igen");
                                        Console.ReadKey();
                                    }
                                }

                            }
                            //Kør denne hvis kravene fra hasSpecialChar, hasNumber og hasCapital ikke opfyldes
                            else
                            {
                                Console.WriteLine("");
                                Console.WriteLine("Du har ikke opfyldt kravene til at oprette en ny bruger!");
                                Console.WriteLine("");
                                Console.WriteLine("Dit brugernavn må ikke være tomt");
                                Console.WriteLine("Din adgangskode skal minimun være 12 karakterer lang");
                                Console.WriteLine("Din adgangskode skal minimun indebære 2 forskellige speciale karakterer");
                                Console.WriteLine("Din adgangskode skal minimun indebære 2 forskellige tal");

                                Console.ReadKey();
                            }
                        }
                        break;
                    //Kør denne, hvis ingen af de cases i switchen ikke udfæres
                    default:
                        Console.Clear();
                        Console.WriteLine("Der er opstået en fejl");
                        Console.WriteLine(" Tryk Enter for at prøve igen");
                        Console.ReadKey();
                        break;
                }

            }

            //Åbner public classen program
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
