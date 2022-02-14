using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicClass
{
    //laver en public class, som kan hentes alle steder fra min solution explorer
    public class Dans_Logic
    {
            //laver en public string/int, som kan hentes alle steder fra i programmet
            public string navn;
            public int point;
            public Dans_Logic(string navn, int point)
            {
                this.navn = navn;
                this.point = point;
            }

            public static Dans_Logic operator +(Dans_Logic a, Dans_Logic b)
            {
                //Opretter en ny string, som tager begge navne og sætter dem på samme string med et & tegn imellem dem
                string navne = a.navn + " & "+ b.navn;
                //Opretter en ny int, som tager begge point og plusser dem med hinanden
                int points = a.point + b.point;

                //retunerer classen Dans Logic med værdierne navne og points.
                return new Dans_Logic(navne, points);
            }
        
    }
}
