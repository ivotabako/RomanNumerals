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

            return ToRoman2(number);
        }

        private int ToRoman2Helper(int number, int step, string roman, Predicate<int> test, StringBuilder sb)
        {
            if (test.Invoke(number))
            {
                sb.Append(roman);

                return ToRoman2Helper(number - step, step, roman, test, sb);
            }            

            return number;
        }

        public string ToRoman2(int self)
        {
            if (self == 0)
            {
                return "";
            }
            else
            {
                StringBuilder sb = new StringBuilder();

                self = ToRoman2Helper(self, 1000, "M", i => i >= 1000, sb);
                sb.Append(" ");
                self = ToRoman2Helper(self, 900, "CM", i => i >= 900 && i < 1000, sb);
                self = ToRoman2Helper(self, 500, "D", i => i >= 500 && i < 900, sb);
                self = ToRoman2Helper(self, 400, "CD", i => i >= 400 && i < 500, sb);
                self = ToRoman2Helper(self, 100, "C", i => i >= 100 && i < 400, sb);
                sb.Append(" ");
                self = ToRoman2Helper(self, 90, "XC", i => i >= 90 && i < 100, sb);
                self = ToRoman2Helper(self, 50, "L", i => i >= 50 && i < 90, sb);
                self = ToRoman2Helper(self, 40, "XL", i => i >= 40 && i < 50, sb);
                self = ToRoman2Helper(self, 10, "X", i => i >= 10 && i < 40, sb);
                sb.Append(" ");
                self = ToRoman2Helper(self, 9, "IX", i => i == 9, sb);
                self = ToRoman2Helper(self, 5, "V", i => i >= 5 && i < 9, sb);
                self = ToRoman2Helper(self, 4, "IV", i => i == 4, sb);
                self = ToRoman2Helper(self, 1, "I", i => i >= 1 && i < 4, sb);

                return sb.ToString().Trim();
            }
        }
    }
}
