using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Easy
{
    public static class Detect_Capital
    {
        //Detect Capital
        public static bool DetectCapitalUse(string word)
        {
            return word == word.ToUpper() || word == word.ToLower() || word[0] == char.ToUpper(word[0])
            && word.Substring(1) == word.Substring(1).ToLower() ? true : false;
        }
    }
}
