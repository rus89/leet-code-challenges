namespace TopInterviewQuestions._05_Longest_Palindromic_Substring;

public class Solution
{
    // public string LongestPalindrome(string s)
    // {
    //     if (s.Length == 1) return s;
    //     if (s.Distinct().Count() == 1) return s;
    //     var allSubstrings = LongestPalindromeRecursive(s);
    //     Stack<string> palindromes = new Stack<string>();
    //     foreach (var substring in allSubstrings)
    //     {
    //         if (IsPalindrome(substring))
    //         {
    //             palindromes.Push(substring);
    //         }
    //     }
    //
    //     string longestPalindrome = palindromes.Peek();
    //     foreach (var palindrome in palindromes)
    //     {
    //         if (palindrome.Length > longestPalindrome.Length)
    //             longestPalindrome = palindrome;
    //     }
    //
    //     return longestPalindrome;
    // }
    //
    // private HashSet<string> LongestPalindromeRecursive(string s)
    // {
    //     if (s.Length == 0) return new HashSet<string>();
    //     var allSubstrings = LongestPalindromeRecursive(s[1..]);
    //     for (int i = 1; i <= s.Length; i++)
    //     {
    //         for (int j = 0; j <= s.Length - i; j++)
    //         {
    //             allSubstrings.Add(s.Substring(j, i));
    //         }
    //     }
    //
    //     return allSubstrings;
    // }
    //
    // private bool IsPalindrome(string s)
    // {
    //     int front = 0;
    //     int back = s.Length - 1;
    //     while (front < back)
    //     {
    //         if (s[front] != s[back])
    //         {
    //             return false;
    //         }
    //
    //         front++;
    //         back--;
    //     }
    //
    //     return true;
    // }

    // Expand around the center technique 
    public string LongestPalindrome(string s)
    {
        if (s == null || s.Length < 1)
        {
            return "";
        }

        var start = 0; // start of sol
        var end = 0; // end of sol
        for (int i = 0; i < s.Length; i++) //loop through each character
        {
            var len1 = ExpandAroundCenter(s, i, i); //length of odd palindrome
            var len2 = ExpandAroundCenter(s, i, i + 1); //length of even palindrome
            var len = Math.Max(len1, len2); // get the max
            if (len > end - start) //end - start = length of current longest palindrome
            {
                start = i - (len - 1) / 2; //since i is the center/ divide length by two and subtract
                end = i + len / 2; //vice versa
            }
        }

        return s.Substring(start, end + 1 - start);
    }

    private int ExpandAroundCenter(string s, int left, int right)
    {
        var l = left;
        var r = right;
        //first two conditions prevent an infinite loop
        //second condition verifies its a palindrome
        while (l >= 0 && r < s.Length && s[l] == s[r])
        {
            l--;
            r++;
        }

        return r - l - 1; //return length
    }
}