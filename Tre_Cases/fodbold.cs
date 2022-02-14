using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tre_Cases
{
    internal class Fodbold
    { 

        internal void Run()
        {
            Console.Clear();
            //Indtastning af mål
            Console.WriteLine("Indtast mål (Hvis intet mål efterlad blank)");
            string mål = Console.ReadLine();

            //Indtastning af afleveringer
            Console.WriteLine("Indtast afleveringer");
            //Læsning af afleveringer & konvertering af string til int
            var passes = Console.ReadLine();
            bool succes = int.TryParse(passes, out int passes_int);
            int afleveringer = passes_int;

            LogicClass.Fodbold fodbold_Object = new LogicClass.Fodbold();
            string CheerResult = fodbold_Object.CheerOrCelebrate(mål, afleveringer);
            Console.WriteLine(CheerResult);

            Console.ReadKey();
        }
    }
}
