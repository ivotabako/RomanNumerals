﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace RomanNumerals
{
    public class ReplaceService
    {
        /// <summary>
        /// Replaces all occurances of integers between 1 and 3999 
        /// with their Roman numerals in the given text
        /// </summary>
        /// <param name="text">the input text</param>
        /// <returns>the output text along with the 
        /// number of replaced integers
        /// </returns>
        public StringWithRomanNumerals DoTransform(string text)
        {
            ConvertServiceSimpleSolution convertSvc = new ConvertServiceSimpleSolution();

            int replacementCount = 0;
            // this regex expression matches the integer numbers range from -3999 to 3999    
            // cases like: abc123 456cde are considered NO match.      
            string resultText = Regex.Replace(text, @"\b([1-9]|[1-9][0-9]|[1-9][0-9][0-9]|[1-3][0-9][0-9][0-9])\b", delegate (Match match)
            {
                replacementCount++;
                int matchInteger = Convert.ToInt32( match.Value);
                return convertSvc.DoTransform(matchInteger);
            });

            var result = new StringWithRomanNumerals(resultText, replacementCount);

            return result;

        }  
    }
}
