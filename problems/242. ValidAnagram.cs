using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeedCode_Problems.problems;
public class Solution242
{
    public bool IsAnagram(string s, string t)
    {
        for (int i = 0; i < s.Length; i++)
        {
            for (int j = 0; j < t.Length; j++)
            {
                if (s[i] == t[j])
                {
                    s = s.Remove(i, 1);
                    t= t.Remove(j, 1);

                    i-= 1;
                    break;

                   
                }
            }
        }
        return s.Length == 0 && t.Length == 0;



    }
}
