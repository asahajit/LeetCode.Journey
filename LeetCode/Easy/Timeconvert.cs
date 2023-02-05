using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Easy
{
    public static class Timeconvert
    {
        public static string timeConversion(string s)
        {
            if (!string.IsNullOrEmpty(s))
            {
                string AMPM = s.Substring(8, 2);
                string hr = s.Substring(0, 2);
                int hrs = int.Parse(hr);
                if (AMPM == "PM" && !(hrs == 12))
                {
                    hrs = hrs + 12;
                    string final = hrs.ToString() + s.Substring(2, 6);
                    return final;
                }
                else if (AMPM == "PM" && hrs == 12)
                {
                    return s.Substring(0, 8);

                }
                else if (AMPM == "AM" && hrs == 12)
                {
                    return "00" + s.Substring(2, 6);
                }
                else if (AMPM == "AM" && !(hrs == 12))
                {
                    return s.Substring(0, 8);
                }
                else
                {
                    return string.Empty;
                }
            }
            else
            {
                return string.Empty;
            }
        }

    }
}
