using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicOOPLTU
{
    internal static class StringExtensions
    {
        public static string AddString(this string firstWord, string secondWord)
        {
            return $"{firstWord} {secondWord}";
        }
    }
}
