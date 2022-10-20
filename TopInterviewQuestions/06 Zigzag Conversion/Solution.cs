using System.Text;

namespace TopInterviewQuestions._06_Zigzag_Conversion;

public class Solution
{
    public string Convert(string s, int numRows)
    {
        int sLength = s.Length;
        StringBuilder[] sb = new StringBuilder[numRows];
        int i;
        for (i = 0; i < sb.Length; i++)
        {
            sb[i] = new StringBuilder();
        }

        i = 0;
        while (i < sLength)
        {
            for (int idx = 0; idx < numRows && i < sLength; idx++) // vertically down
                sb[idx].Append(s[i++]);
            for (int idx = numRows - 2; idx >= 1 && i < sLength; idx--) // obliquely up
                sb[idx].Append(s[i++]);
        }

        for (int idx = 1; idx < sb.Length; idx++)
            sb[0].Append(sb[idx]);
        return sb[0].ToString();
    }
}