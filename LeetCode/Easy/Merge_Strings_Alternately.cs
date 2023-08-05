using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Easy
{
    public static class Merge_Strings_Alternately
    {
        public static string MergeAlternately(string word1, string word2)
        {
            int maxlength = word1.Length > word2.Length ? word1.Length : word2.Length;
            int minlength = word1.Length < word2.Length ? word1.Length : word2.Length;
            string result = string.Empty;

            for (int i = 0; i < maxlength; i++)
            {
                if (word1.Length >= minlength && word1.Length <= maxlength && word1.Length>i)
                {
                    result = result+word1.Substring(i,1);
                }
                if (word2.Length >= minlength && word2.Length <= maxlength && word2.Length > i)
                {
                    result = result + word2.Substring(i, 1);
                }
            }
            return result;

        }
    }
}
