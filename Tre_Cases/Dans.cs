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
            var danser1 = Console.ReadLine().ToLower();

            string danser1Char = char.ToUpper(danser1[0]) + danser1.Substring(1);

            Console.WriteLine("Indtast point til danseren: {0}", danser1Char);
            var danser1p = Convert.ToInt32(Console.ReadLine());


            Console.Clear();

            Console.WriteLine("Indtast anden danser");
            var danser2 = Console.ReadLine().ToLower();
            string danser2Char = char.ToUpper(danser2[0]) + danser2.Substring(1);


            Console.WriteLine("Indtast point til danseren: {0}", danser2Char);
            var danser2p = Convert.ToInt32(Console.ReadLine());

            Console.Clear();

            Console.WriteLine("Danser 1: {0} - {1} point.", danser1Char, danser1p);
            Console.WriteLine("");
            Console.WriteLine("Danser 2: {0} - {1} point.", danser2Char, danser2p);
            Console.WriteLine("");

            Dans_Logic dans1 = new Dans_Logic(danser1Char, danser1p);
            Dans_Logic dans2 = new Dans_Logic(danser2Char, danser2p);

            Dans_Logic total = dans1 + dans2;

            Console.WriteLine("Tryk Enter for at få samlet point");
            Console.ReadKey();
            Console.Clear();
            Console.WriteLine("Dansere:");
            Console.WriteLine(total.navn);
            Console.WriteLine("");
            Console.WriteLine("Samlede point:");
            Console.WriteLine(total.point);


        }
    }
}
