using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeedCode_Problems.problems;
public class Solution342
{
    public bool IsPowerOfFour(int n)
    {
        if (n <= 0) { return false; }
        if (n == 1) return true;
        double a = n;
        while (a >= 4)
        {
            a = a / 4;
            if (a == 1)
            {
                return true;
            }
            else if (a > 1 && a < 4)
            {
                return false;
            }
        }
        return false;

    }
}
