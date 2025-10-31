namespace LeedCode_Problems.problems;

public class Solution389
{
    public char FindTheDifference(string s, string t)
    {
        foreach (char c in s)
        {
            int index = t.IndexOf(c);
            if (index != -1)
                t = t.Remove(index, 1);
        }

        return t[0];
    }
}




