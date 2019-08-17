using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day1Project
{
    static class StringExtensions
    {
        public static int wordCount(this string input,int number)
        {
            string[] userString = input.Split(new char[] { ' ', '?' },
                                  StringSplitOptions.RemoveEmptyEntries);
            int wordCount = userString.Length; ;
            return wordCount;
        }
    }
}
