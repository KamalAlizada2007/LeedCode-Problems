using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeedCode_Problems.problems;
public class Solution326
{
    public bool IsPowerOfThree(int n)
    {
        if (n <= 0) return false;
        while (n % 3 == 0)
        {
            n /= 3;
        }
        return n == 1;
    }
}

