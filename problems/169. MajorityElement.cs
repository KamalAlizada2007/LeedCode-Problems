namespace LeedCode_Problems.problems;
public class Solution169
{
    public int MajorityElement(int[] nums)
    {
        int candidate = 0;
        int count = 0;

        foreach (int num in nums)
        {
            if (count == 0)
                candidate = num;

            count += (num == candidate) ? 1 : -1;
        }

        int freq = nums.Count(x => x == candidate);
        if (freq > nums.Length / 2)
            return candidate;

        return -1;
    }
}
