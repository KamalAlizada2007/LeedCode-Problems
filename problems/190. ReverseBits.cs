using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeedCode_Problems.problems;
public class Solution190
{
    public int ReverseBits(int n)
    {
        uint num = (uint)n;
        uint result = 0;

        for (int i = 0; i < 32; i++)
        {
            result <<= 1;
            result |= (num & 1);
            num >>= 1;
        }

        return (int)result;
    }
}

