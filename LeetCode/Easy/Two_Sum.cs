using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.Intrinsics.X86;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Easy
{

    //Two Sum
    public static class Two_Sum
    {
        public static int[] TwoSum(int[] nums, int target)
        {

            List<int> numlist = nums.ToList();
            int p1 = 0;
            List<int> newarray = new List<int>();
            foreach (int i in numlist)
            {
                int p2 = 0;
                foreach (int j in numlist)
                {
                    if (i + j == target && p1 != p2)
                    {
                        newarray.Add(p1);
                        newarray.Add(p2);
                        return newarray.ToArray();
                    }
                    p2 = p2 + 1;
                }
                p1 = p1 + 1;
            }
            return newarray.ToArray();
        }
    }
}
