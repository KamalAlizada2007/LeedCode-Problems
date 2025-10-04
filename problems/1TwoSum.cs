namespace LeedCode_Problems.problems;

public class Solution
{
    public bool IsPalindrome(int x)
    {
        int a = 0;
        int c = x;
        while (x > 0)
        {
            int b = x % 10;
            a = a * 10 + b;
            x = x / 10;
        }

        if (a == c)
        {
            return true;
        }
        else
        {
            return false;
        }

    }

}