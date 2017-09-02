using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RomanNumerals
{
    public static class NumberExtentions
    {
        public static int LastDigit(this int self)
        {
            return self % 10;
        }

        public static int TenthsDigit(this int self)
        {
            return (self % 100 - self % 10) / 10;
        }

        public static int HundredsDigit(this int self)
        {
            return (self % 1000 - self % 100) / 100;
        }

        public static int ThousandsDigit(this int self)
        {
            return (self % 10000 - self % 1000) / 1000;
        }

        private static string ToRoman(this int self, string first, string second, string third)
        {
            return GenerateNumeral(self, first, second, third);
        }

        public static string ToRoman(this int self)
        {
            var thousands = self.ThousandsDigit().ToRoman("M", "-", "-").TrimStart();

            var hundreds = self.HundredsDigit().ToRoman("C", "D", "M").TrimStart();

            var tenths = self.TenthsDigit().ToRoman("X", "L", "C").TrimStart();

            var digits = self.LastDigit().ToRoman("I", "V", "X").Trim();

            return string.Format("{0}{1}{2}{3}", thousands, hundreds, tenths, digits).Trim();
        }

        private static string GenerateNumeral(int digit, string first, string second, string third)
        {
            StringBuilder sb = new StringBuilder();

            // flag which is 'true' if we should append and 'false' if we should prepend
            bool append = true;

            // while decrementing or subtracting values from the digit number we are building the Roman representation.
            while (digit > 0)
            {
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

            sb.Append(" ");

            return sb.ToString();
        }
    }
}
