using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeedCode_Problems.problems;
public class Solution20
{
    public bool IsValid(string s)
    {

        if (s.Length % 2 != 0)
            return false;

        while (s.Contains("()") || s.Contains("[]") || s.Contains("{}"))
        {

            s = s.Replace("()", "");
            s = s.Replace("[]", "");
            s = s.Replace("{}", "");
        }


        return s.Length == 0;
    }
}

