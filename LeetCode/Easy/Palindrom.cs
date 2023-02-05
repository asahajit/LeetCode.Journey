using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Easy
{
    //Palindrome Number
    public class Palindrom
    {
        public static int numDigits(int n)
        {
            if (n < 0)
            {
                n = n == int.MinValue ? int.MaxValue : -n;
            }
            if (n < 10) return 1;
            if (n < 100) return 2;
            if (n < 1000) return 3;
            if (n < 10000) return 4;
            if (n < 100000) return 5;
            if (n < 1000000) return 6;
            if (n < 10000000) return 7;
            if (n < 100000000) return 8;
            if (n < 1000000000) return 9;
            return 10;
        }

        public static int[] digitArr2(int n)
        {
            var result = new int[numDigits(n)];
            for (int i = result.Length - 1; i >= 0; i--)
            {
                result[i] = n % 10;
                n /= 10;
            }
            return result;
        }

        public static bool IsPalindrome(int x)
        {
            if (x > 0)
            {
                if (x == 0 || x < 10)
                {
                    return true;
                }
                int[] outarry = digitArr2(x);
                int lencover = outarry.Length / 2;
                int leng = outarry.Length - 1;
                int cnt = 0;
                for (int i = 0; i <= lencover; i++)
                {
                    if (outarry[i] == outarry[leng - i])
                    {
                        cnt = cnt + 1;
                        if (cnt == lencover)
                        {
                            return true;
                        }
                    }
                    else
                    {
                        return false;
                    }

                }
                return false;
            }
            else if (x == 0)
            {
                return true;
            }
            else
            {
                return false;
            }

        }
    }
}

