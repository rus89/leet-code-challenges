namespace TopInterviewQuestions._03_Longest_Substring_Without_Repeating_Characters;

public class Solution
{
    public int LengthOfLongestSubstring(string s)
    {
        if (string.IsNullOrEmpty(s)) return 0;
        if (string.IsNullOrWhiteSpace(s)) return 1;
        const int numberOfAllowedAsciiCharacters = 95;
        int[] asciiCharacters = new int[numberOfAllowedAsciiCharacters];
        List<int> numberOfCharsInAllSubstrings = new List<int>();
        int j = 0;
        for (int i = 0; i < s.Length; i++, j++)
        {
            if (++asciiCharacters[s[i] - ' '] > 1)
            {
                if (i == numberOfAllowedAsciiCharacters) return numberOfAllowedAsciiCharacters;
                if (numberOfCharsInAllSubstrings.Contains(j)) break;
                numberOfCharsInAllSubstrings.Add(j);
                asciiCharacters = new int[numberOfAllowedAsciiCharacters];
                j = 0;
                asciiCharacters[s[i] - ' ']++;
            }
        }

        numberOfCharsInAllSubstrings.Add(j++);
        numberOfCharsInAllSubstrings.Add(LengthOfLongestSubstring(s[1..]));

        return numberOfCharsInAllSubstrings.Max();
    }
}