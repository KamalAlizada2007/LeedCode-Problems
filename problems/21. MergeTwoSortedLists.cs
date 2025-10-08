namespace LeedCode_Problems.problems;

public class Solution21
{
    public ListNode MergeTwoLists(ListNode list1, ListNode list2)
    {
        if (list1 == null)
            return list2;
        if (list2 == null)
            return list1;

        ListNode result = list1;

        while (result.next != null)
        {
            result = result.next;
        }

        result.next = list2;



        List<int> result1 = new List<int>();
        for (var cur = list1; cur != null; cur = cur.next)
        {
            result1.Add(cur.val);
        }
        result1.Sort();

        ListNode endResult = new ListNode(0);
        var newCur = endResult;
        foreach (var v in result1)
        {
            newCur = newCur.next = new ListNode(v);
        }

        return endResult.next;

    }
}
