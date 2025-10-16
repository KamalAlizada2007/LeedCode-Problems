namespace LeedCode_Problems.problems;
public class Solution70
{
    public int ClimbStairs(int n)
    {

        if (n == 1)
            return 1;
        if (n == 2)
            return 2;
        int sum = 0;
        List<int> list = new List<int>();
        list.Add(1);
        list.Add(2);


        for (int i = 0; i < n - 2; i++)
        {
            sum = list[i] + list[i + 1];
            list.Add(sum);


        }

        int result = list.Last();
        return result;






    }
}
