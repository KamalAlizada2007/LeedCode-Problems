namespace LeedCode_Problems.problems;
public class Solution35
{
    public int SearchInsert(int[] nums, int target)
    {

        if (nums.Contains(target))
        {
            return Array.IndexOf(nums, target);
        }

        int[] newArray = new int[nums.Length + 1];

        int i = 0, j = 0;

        while (i < nums.Length && nums[i] < target)
        {
            newArray[j++] = nums[i++];

        }

        newArray[j++] = target;

        while (j < nums.Length)
        {
            newArray[j++] = nums[i++];
        }

        return Array.IndexOf(newArray, target);



    }
}
