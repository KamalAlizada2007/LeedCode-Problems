namespace LeedCode_Problems.problems;
public class Solution83
{
    public ListNode DeleteDuplicates(ListNode head)
    {

        List<int> duplicates = new List<int>();
        for (var cur = head; cur != null; cur = cur.Next)
        {
            duplicates.Add(cur.Value);
        }

        duplicates.Sort();

        for (int i = 0; i < duplicates.Count; i++)
        {
            if (duplicates.Contains(duplicates[i]))
            {

                duplicates.Remove(duplicates[i]);

            }
        }

        ListNode endResult = new ListNode(1);
        var newCur = endResult;
        foreach (var v in duplicates)
        {
            newCur = newCur.next = new ListNode(v);
        }


        return endResult;


    }
}
