namespace LeedCode_Problems.problems;
public class Solution231
{
    public bool IsPowerOfTwo(int n)
    {
        if (n <= 0) return false;
        while (n % 2 == 0)
        {
            n /= 2;
        }
        return n == 1;
    }
}
