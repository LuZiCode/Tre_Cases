using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Tre_Cases
{
    internal class Password
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
                        Console.WriteLine("Login til eksisterende bruger");
                        Console.WriteLine("");
                        Console.WriteLine("Indtast brugernavn: ");
                    break;
                case '2':
                    Console.WriteLine("");
                    break;
                case '3':
                    string adgangskode = "";
                    while(adgangskode.Length < 12)
                    {
                    Console.Clear();
                    Console.WriteLine("Opret en ny bruger:");
                    Console.WriteLine("");
                    Console.Write("Indtast brugernavn: ");
                    string brugernavn = Console.ReadLine();
                    Console.WriteLine();
                    Console.Write("Indtast adgangskode: ");
                    adgangskode = Console.ReadLine();
                    Console.WriteLine("");

                    if (brugernavn != null && adgangskode.Length >= 12)
                    {
                        string adgangskode2 = "";
                        while (adgangskode != adgangskode2)
                        {
                            Console.Write("Gentast adgangskode: ");
                            adgangskode2 = Console.ReadLine();

                        if (adgangskode == adgangskode2)
                        {
                            string filePath = @"C:\Users\luczie\Desktop\The Three Cases - CSharp\Tre_Cases\Data\adgangskode.txt";
                            List<string> lines = File.ReadAllLines(filePath).ToList();
                            lines.Add(brugernavn); lines.Add(adgangskode);
                            File.WriteAllLines(filePath, lines);

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
}
