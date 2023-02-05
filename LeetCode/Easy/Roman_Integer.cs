using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Easy
{
    public static class Roman_Integer
    {
        public static int RomanToInt(string s)
        {

            int total = 0;
            int current = 0;
            for (int i = s.Length - 1; i >= 0; i--)
            {
                char chard = s[i];
                switch (chard)
                {
                    case 'I':
                        total = total + 1;
                        current = 1;
                        break;
                    case 'V':
                        total = total + 5;
                        current = 5;
                        break;
                    case 'X':
                        total = total + 10;
                        current = 10;
                        break;
                    case 'L':
                        total = total + 50;
                        current = 50;
                        break;
                    case 'C':
                        total = total + 100;
                        current = 100;
                        break;
                    case 'D':
                        total = total + 500;
                        current = 500;
                        break;
                    case 'M':
                        total = total + 1000;
                        current = 1000;
                        break;

                }

                if (current > total)
                {
                    total -= current * 2;
                }

            }
            return total;
        }
    }
}
