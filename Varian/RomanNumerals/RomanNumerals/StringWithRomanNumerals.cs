using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RomanNumerals
{
    /// <summary>
    /// This class contain text in which the
    /// integers between 1 and 3999 are replaced 
    /// with their Roman numerals
    /// 
    /// Also the number of the replacements
    /// </summary>
    public class StringWithRomanNumerals
    {
        /// <summary>
        /// the number of replaced integers
        /// </summary>
        public int ReplacedNumbersCount { get; private set; }

        /// <summary>
        /// the transformed text
        /// </summary>
        public string Text { get; private set; }
    }
}
