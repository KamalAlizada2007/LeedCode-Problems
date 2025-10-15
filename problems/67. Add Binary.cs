namespace LeedCode_Problems.problems;
public class Solution67
{
    public string AddBinary(string a, string b)
    {


        int i = a.Length - 1;
        int j = b.Length - 1;
        int carry = 0;
        List<char> result = new List<char>();

        while (i >= 0 || j >= 0 || carry > 0)
        {
            int bitA = (i >= 0) ? a[i] - '0' : 0;
            int bitB = (j >= 0) ? b[j] - '0' : 0;

            int sum = bitA + bitB + carry;
            result.Add((char)((sum % 2) + '0'));
            carry = sum / 2;

            i--;
            j--;
        }

        result.Reverse();
        string res = new string(result.ToArray());
        return res;

    }
}

