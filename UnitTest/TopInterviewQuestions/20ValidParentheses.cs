using TopInterviewQuestions._20_Valid_Parentheses;
using Xunit;

namespace UnitTest.TopInterviewQuestions;

public class ValidParentheses
{
    [Fact]
    public static void ValidParenthesesTester()
    {
        Solution solution = new Solution();
        Assert.True(solution.IsValid("()"));
        Assert.True(solution.IsValid("()[]{}"));
        Assert.False(solution.IsValid("(]"));
        Assert.False(solution.IsValid("]["));
        Assert.False(solution.IsValid("("));
        Assert.False(solution.IsValid(""));
        Assert.True(solution.IsValid("((([[[{{{}}}]]])))"));
    }
}