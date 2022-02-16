using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicClass
{
    public class Password_Logic
    {
        //Opretter en ny public int, som blivere refereret til inde i program.cs
        public int HasSpecialChar(string adgangskode)
        {
            //Opretter en string, som indebærer alle specialle charectors
            string specialChar = @"|!#$%&/()=?»«@£§€{}.-;~`'<>_,";
            //Laver en ny string, som har formålet om at blive talt på hvor mange gange der opstår et forskelligt special char i stringen adgangskode
            int numberofspecialchar = 0;
            //en foreach loop, som gentages hver gang der opstår et special char i item som matcher specialchar
            foreach (var item in specialChar)
            {
                //hvis adgangskoden indeholder item, så kør denne if sætning
                if (adgangskode.Contains(item))
                {
                    //Pluser denne int hver gang if sætningen bliver opfyldt
                    numberofspecialchar++;
                }
            }
            //Sender værdien tilbage i program.cs, når foreach loopen ikke kan opfyldes længere
            return numberofspecialchar;
        }
        //Opretter en ny public int, som blivere refereret til inde i program.cs
        public int HasNumber(string adgangskode)
        {
            //Opretter en string, som indebærer alle tal
            string numbers = @"1234567890";
            //Laver en ny string, som har formålet om at blive talt på hvor mange gange der opstår et forskelligt special char i stringen adgangskode
            int countofnumbers = 0;
            //en foreach loop, som gentages hver gang der opstår et tal i item som matcher int numbers
            foreach (var items in numbers)
            {
                //hvis adgangskoden indeholder items, så kør denne if sætning
                if (adgangskode.Contains(items))
                {
                    //Pluser denne int hver gang if sætningen bliver opfyldt
                    countofnumbers++;
                }
            }
            //Sender værdien tilbage i program.cs, når foreach loopen ikke kan opfyldes længere
            return countofnumbers;
        }
        //Opretter en ny public int, som blivere refereret til inde i program.cs
        public int HasCapital(string adgangskode)
        {
            //Laver en ny string, som har formålet om at blive talt på hvor mange gange der opstår et CAPS tegn i stringen adgangskode
            int counter = 0;
            for (int i = 0; i < adgangskode.Length; i++)
            {
                //Hvis en karakter i adgangskode er CAPS så +1 til counter
                if (char.IsUpper(adgangskode[i]))
                {
                    counter++;
                }
            }
            return counter;
        }
    }
}
