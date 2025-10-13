using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeedCode_Problems.problems;
public class Solution28
{
    public int StrStr(string haystack, string needle)
    {
        int index = haystack.IndexOf(needle);

        if (index != -1)
        {
            return index;
        }

        return -1;

    }
}
