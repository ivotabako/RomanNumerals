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
    public class ConvertServiceAlgorithmicSolution
    {
        /// <summary>
        /// Transforms an arabic number between 1 and 3999 to roman one
        /// </summary>
        /// <param name="number">the arabic number input</param>
        /// <returns>the string representing the roman numeral</returns>
        public string DoTransform(int number)
        {
            if (number < 1 || number > 3999)
            {
                return number.ToString();
            }

            StringBuilder sbThousands = new StringBuilder();
            int thousandsDigit = (number % 10000 - number % 1000) / 1000;
            GenerateNumeral(thousandsDigit, sbThousands, "M", "-", "-");

            StringBuilder sbHundreds = new StringBuilder();
            int hundredsDigit = (number % 1000 - number % 100) / 100;
            GenerateNumeral(hundredsDigit, sbHundreds, "C", "D", "M");

            StringBuilder sbTenths = new StringBuilder();
            int tenthDigit = (number % 100 - number % 10) / 10;
            GenerateNumeral(tenthDigit, sbTenths, "X", "L", "C");

            StringBuilder sbDigits = new StringBuilder();
            int lastDigit = number % 10;
            GenerateNumeral(lastDigit, sbDigits, "I", "V", "X");

            return sbThousands.Append(sbHundreds.Append(sbTenths.Append(sbDigits))).ToString().Trim();
        }

        private void GenerateNumeral(int digit, StringBuilder sb, string first, string second, string third)
        {
            // flag which is 'true' if we should append and 'false' if we should prepend
            bool append = true;

            bool hasDelimiter = false;

            // while decrementing or subtracting values from the digit number we are building the Roman representation.
            while (digit > 0)
            {
                hasDelimiter = true;
                if (digit < 4)
                {
                    //append to the end
                    if (append)
                        sb.Append(first);
                    //insert in the front
                    if (!append)
                        sb.Insert(0, first);
                    digit--;
                }

                if (digit >= 4 && digit < 9)
                {
                    sb.Append(second);
                    digit = digit - 5;
                    append = digit > 0;
                    digit = Math.Abs(digit);
                }

                if (digit >= 9)
                {
                    sb.Append(third);
                    digit = digit - 10;
                    append = digit > 0;
                    digit = Math.Abs(digit);
                }
            }

            if (hasDelimiter)
                sb.Append(" ");
        }
    }
}

