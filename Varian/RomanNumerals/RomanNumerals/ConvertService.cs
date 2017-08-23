using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RomanNumerals
{
    public class ConvertService
    {
        private Dictionary<int, string> mappings = new Dictionary<int, string>();
        

        public ConvertService()
        {
            mappings.Add(1, "I");
            mappings.Add(5, "V");
            mappings.Add(10, "X");
            mappings.Add(50, "L");
            mappings.Add(100, "C");
            mappings.Add(500, "D");
            mappings.Add(1000, "M");
        }

        public string DoTransform(int number)
        {
            return mappings[number];
        }
    }
}
