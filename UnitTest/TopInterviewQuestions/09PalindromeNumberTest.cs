using TopInterviewQuestions._09_Palindrome_Number;
using Xunit;

namespace UnitTest.TopInterviewQuestions;

public class PalindromeNumberTest
{
    [Fact]
    public static void PalindromeTester()
    {
        Solution solution = new Solution();
        Assert.True(solution.IsPalindrome(121));
        Assert.True(solution.IsPalindrome(1234554321));
        Assert.True(solution.IsPalindrome(123454321));
        Assert.False(solution.IsPalindrome(123));
        Assert.False(solution.IsPalindrome(-121));
        Assert.True(solution.IsPalindrome(0000));
        Assert.True(solution.IsPalindrome(0));
        Assert.False(solution.IsPalindrome(010));
        Assert.False(solution.IsPalindrome(10));
        Assert.False(solution.IsPalindrome(00100));
    }
}