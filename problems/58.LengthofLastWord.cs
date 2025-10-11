using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeedCode_Problems.problems;
public class Solution58
{
    public int LengthOfLastWord(string s)
    {

        string[] words = s.Trim().Split(' ', StringSplitOptions.RemoveEmptyEntries);
        string lastWord = words[^1];
        return lastWord.Length;

    }
}
