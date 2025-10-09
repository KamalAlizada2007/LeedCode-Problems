using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeedCode_Problems.problems;

public class Solution100
{
    public bool IsSameTree(TreeNode p, TreeNode q)
    {
        if (p == null && q == null)
            return true;

        if (p == null || q == null)
            return false;

        return (p.val == q.val) &&
        IsSameTree(p.left, q.left) &&
        IsSameTree(p.right, q.right);







    }
}

