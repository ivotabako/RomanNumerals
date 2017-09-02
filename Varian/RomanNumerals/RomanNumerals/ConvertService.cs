using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RomanNumerals
{
    /// <summary>
    /// the class converts arabic numbers to roman numerals
    /// </summary>
    public class ConvertService : ISolution
    {
        private Dictionary<int, string> mappings = new Dictionary<int, string>();
        
        public ConvertService()
        {
            mappings.Add(1, "I");
            mappings.Add(2, "II");
            mappings.Add(3, "III");
            mappings.Add(4, "IV");
            mappings.Add(5, "V");
            mappings.Add(6, "VI");
            mappings.Add(7, "VII");
            mappings.Add(8, "VIII");
            mappings.Add(9, "IX");
            mappings.Add(10, "X");
            mappings.Add(20, "XX");
            mappings.Add(30, "XXX");
            mappings.Add(40, "XL");
            mappings.Add(50, "L");
            mappings.Add(60, "LX");
            mappings.Add(70, "LXX");
            mappings.Add(80, "LXXX");
            mappings.Add(90, "XC");
            mappings.Add(100, "C");
            mappings.Add(200, "CC");
            mappings.Add(300, "CCC");
            mappings.Add(400, "CD");
            mappings.Add(500, "D");
            mappings.Add(600, "DC");
            mappings.Add(700, "DCC");
            mappings.Add(800, "DCCC");
            mappings.Add(900, "CM");
            mappings.Add(1000, "M");
            mappings.Add(2000, "MM");
            mappings.Add(3000, "MMM");            
        }

        /// <summary>
        /// Transforms an arabic number between 1 and 3999 to roman one
        /// </summary>
        /// <param name="number">the arabic number input</param>
        /// <returns>the string representing the roman numeral</returns>
        public string DoTransform(int number)
        {
            if (number < 1 || number > 3999 )
            {
                return number.ToString();
            }

            if(mappings.Keys.Contains(number))
                return mappings[number];
            else
            {
                StringBuilder sb = new StringBuilder();

                int thousandsDigit = number % 10000 - number % 1000;

                AppendDigit(sb, thousandsDigit);

                int hundredsDigit = number % 1000 - number % 100;

                AppendDigit(sb, hundredsDigit);

                int tenthDigit = number % 100 - number % 10;

                AppendDigit(sb, tenthDigit);                

                int lastDigit = number % 10;

                if (mappings.Keys.Contains(lastDigit))
                    sb.Append( mappings[lastDigit]);

                return sb.ToString();
            }
        }

        private void AppendDigit(StringBuilder sb, int digit)
        {
            if (mappings.Keys.Contains(digit))
            {
                sb.Append(mappings[digit]);
                sb.Append(" ");
            }
        }

    }
}
