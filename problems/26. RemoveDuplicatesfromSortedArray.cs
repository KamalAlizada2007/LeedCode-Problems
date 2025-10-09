﻿namespace LeedCode_Problems.problems
{
	public class Solution26
	{
		public int RemoveDuplicates(int[] nums)
		{

			Array.Sort(nums);

			int result = 1;
			for (int i = 1; i < nums.Length; i++)
			{
				if (nums[i] != nums[i - 1])
				{
					nums[result] = nums[i];
					result++;
				}
			}
			return result;



		}
	}
}
