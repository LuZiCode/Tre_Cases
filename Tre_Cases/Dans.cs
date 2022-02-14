using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LogicClass;

namespace Tre_Cases
{
    public class Dans
    {
        public void Run()
        {
            Console.Clear();
            Console.WriteLine("Indtast første danser");
            //laver alle de chars som de indtaster til automatisk ingen CAPS, hvis nu de skulle skrive det ene navn med CAPS og det andet navn uden
            var danser1 = Console.ReadLine().ToLower();

            //Laver en ny string, som tager det første bogstav af danser1 og gør det til Capital. Hvis nu de skriver "ziegler" bliver det printet om til "Ziegler"
            string danser1Char = char.ToUpper(danser1[0]) + danser1.Substring(1);

            Console.WriteLine("Indtast point til danseren: {0}", danser1Char);
            var danser1p = Convert.ToInt32(Console.ReadLine());


            Console.Clear();

            Console.WriteLine("Indtast anden danser");

            //laver alle de chars som de indtaster til automatisk ingen CAPS, hvis nu de skulle skrive det ene navn med CAPS og det andet navn uden
            var danser2 = Console.ReadLine().ToLower();

            //Laver en ny string, som tager det første bogstav af danser1 og gør det til Capital. Hvis nu de skriver "ziegler" bliver det printet om til "Ziegler"
            string danser2Char = char.ToUpper(danser2[0]) + danser2.Substring(1);


            Console.WriteLine("Indtast point til danseren: {0}", danser2Char);
            var danser2p = Convert.ToInt32(Console.ReadLine());

            Console.Clear();

            //Viser de enkelte dansers navne og deres individuelle point
            Console.WriteLine("Danser 1: {0} - {1} point.", danser1Char, danser1p);
            Console.WriteLine("");
            Console.WriteLine("Danser 2: {0} - {1} point.", danser2Char, danser2p);
            Console.WriteLine("");

            //"Dans_Logic" navigerer over til min danslogic class under min class libary og opretter en ny class ved navn "dans1" & "dans2"
            //"new Dans_Logic" åbner en ny cmd og overfører min string og int over til min class libary (danser1Char, danser1p) 
            Dans_Logic dans1 = new Dans_Logic(danser1Char, danser1p);
            Dans_Logic dans2 = new Dans_Logic(danser2Char, danser2p);

            //Laver en ny class ved navn total, som tager mine to forrige classes, og putter dem sammen
            Dans_Logic total = dans1 + dans2;

            Console.WriteLine("Tryk Enter for at få samlet point");
            Console.ReadKey();
            Console.Clear();
            Console.WriteLine("Dansere:");
            //Bruger den forrige total class og putter string navn ind, sosm hentes fra mit class libary
            Console.WriteLine(total.navn);
            Console.WriteLine("");
            Console.WriteLine("Samlede point:");
            //Bruger den forrige total class og putter int point ind, sosm hentes fra mit class libary
            Console.WriteLine(total.point);


        }
    }
}
