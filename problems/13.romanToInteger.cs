namespace LeedCode_Problems.problems;

public class Solution13
{
    public int RomanToInt(string s)
    {
        Dictionary<char, int> romaNumber = new Dictionary<char, int>{
            {'I', 1},
            {'V', 5},
            {'X', 10},
            {'L', 50},
            {'C', 100},
            {'D', 500},
            {'M', 1000}
        };
        int sum = 0;
        for (int i = 0; i < s.Length; i++)
        {
            int value = romaNumber[s[i]];

            if (i + 1 < s.Length && romaNumber[s[i + 1]] > value)
            {
                sum -= value;
            }
            else
            {
                sum = sum + value;

            }
        }
        return sum;
    }
}
