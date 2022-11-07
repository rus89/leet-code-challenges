namespace TopInterviewQuestions._14_Longest_Common_Prefix;

public class Solution
{
    public string LongestCommonPrefix(string[] strs)
    {
        switch (strs.Length)
        {
            case < 1 or > 200:
                return string.Empty;
            case 1:
                return strs[0];
        }

        if (strs.Contains(string.Empty)) return string.Empty;

        for (var i = 0; i < strs.Length; i++)
        {
            var s = strs[i];
            if (s.Length is <= 0 or > 200) return string.Empty;
            for (var j = 0; j < s.Length; j++)
            {
                var c = s[j];
                if (!char.IsLetter(c)) return string.Empty;
            }
        }

        string theShortest = strs[0];
        for (int i = 0; i < strs.Length; i++)
        {
            if (strs[i].Length < theShortest.Length)
            {
                theShortest = strs[i];
            }
        }

        string result = string.Empty;
        int index = 0;
        while (index < strs.Length)
        {
            if (!strs[index].StartsWith(theShortest))
            {
                theShortest = theShortest[..^1];
                index = 0;
            }
            else
            {
                result = theShortest;
                index++;
            }
        }
        return result;
    }
}