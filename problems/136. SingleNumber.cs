namespace LeedCode_Problems.problems;
public class Solution136

{
    public int SingleNumber(int[] nums)
    {
        List<int> result = new List<int>();
        for (int i = 0; i < nums.Length; i++)
        {
            if (result.Contains(nums[i]))
            {
                result.Remove(nums[i]);
            }
            else
            {
                result.Add(nums[i]);
            }
        }
        return result[0];

    }
}

