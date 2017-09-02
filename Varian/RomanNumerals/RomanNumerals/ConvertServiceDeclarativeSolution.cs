using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RomanNumerals
{
    public class ConvertServiceDeclarativeSolution : ISolution
    {
        public string DoTransform(int number)
        {
            if (number < 1 || number > 3999)
            {
                return number.ToString();
            }

            return number.ToRoman();
        }
    }
}
