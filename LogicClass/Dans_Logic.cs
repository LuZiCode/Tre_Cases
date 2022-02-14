using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicClass
{
    public class Dans_Logic
    {

            public string navn;
            public int point;
            public Dans_Logic(string navn, int point)
            {
                this.navn = navn;
                this.point = point;
            }

            public static Dans_Logic operator +(Dans_Logic a, Dans_Logic b)
            {
                string navne = a.navn + " & "+ b.navn;
                int points = a.point + b.point;

                return new Dans_Logic(navne, points);
            }
        
    }
}
