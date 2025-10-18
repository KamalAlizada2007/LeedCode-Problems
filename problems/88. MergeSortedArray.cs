using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeedCode_Problems.problems;
public class Solution88
{
    public void Merge(int[] nums1, int m, int[] nums2, int n)
    {
        int a  = 0;
        for (int i = m; i < nums1.Length; i++)
        {
            nums1[i] = nums2[a];
            a++;
        }

        List<int> list = new List<int>();
        for (int i = 0; i < nums1.Length; i++)
        {
            list.Add(nums1[i]);
        }

        list.Sort();

        for (int i = 0;i<list.Count;i++)
        {
            nums1 [i] = list[i];
        }

       

        return;

        

                


    }
}
