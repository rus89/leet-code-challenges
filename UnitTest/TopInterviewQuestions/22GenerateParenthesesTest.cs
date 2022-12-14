using TopInterviewQuestions._22_Generate_Parentheses;
using Xunit;

namespace UnitTest.TopInterviewQuestions;

public class GenerateParenthesesTest
{
    [Fact]
    public static void GenerateParenthesesTester()
    {
        Solution solution = new Solution();
        List<string> expected = new List<string> { "((()))", "(()())", "(())()", "()(())", "()()()" };
        Assert.Equal(expected, solution.GenerateParenthesis(3));
    }
}