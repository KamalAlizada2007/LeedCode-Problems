using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeedCode_Problems.problems;
public class Solution
{
    public int SingleNumber(int[] nums)
    {
        List<int> result = new List<int>();
        for (int i = 0; i < nums.Length; i++)
        {
            if (!nums.Contains(nums[i]))
            {
                result.Add(i);
            }
        }
        return result;

    }
}

