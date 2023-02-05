using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Easy
{
    //3. Longest Substring Without Repeating Characters
    public static class Longest_Substring
    {
        public static int LengthOfLongestSubstring(string s)
        {
            // Creating a set to store the last positions of occurrence
            Dictionary<char, int> seen = new Dictionary<char, int>();
            int maximum_length = 0;

            // starting the initial point of window to index 0
            int start = 0;

            for (int end = 0; end < s.Length; end++)
            {
                // Checking if we have already seen the element or not
                if (seen.ContainsKey(s[end]))
                {
                    // If we have seen the number, move the start pointer
                    // to position after the last occurrence
                    start = Math.Max(start, seen[s[end]] + 1);
                }

                // Updating the last seen value of the character
                seen[s[end]] = end;
                maximum_length = Math.Max(maximum_length, end - start + 1);
            }
            return maximum_length;
        }
    }
}
