using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeedCode_Problems.problems;

public class Solution217

{
    public bool ContainsDuplicate(int[] nums)
    {
        HashSet<int> seen = new HashSet<int>();

        foreach (int num in nums)
        {
            if (seen.Contains(num))
                return true;

            seen.Add(num);
        }

        return false;
    }
}

