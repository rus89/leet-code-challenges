using TopInterviewQuestions._08_String_to_Integer__atoi_;
using Xunit;

namespace UnitTest.TopInterviewQuestions;

public class StringToInteger_atoi_Test
{
    [Fact]
    public static void AtoiTester()
    {
        Solution solution = new Solution();
        Assert.Equal(42, solution.MyAtoi("42"));
        Assert.Equal(-42, solution.MyAtoi("      -42"));
        Assert.Equal(4193, solution.MyAtoi("4193 with words"));
        Assert.Equal(0, solution.MyAtoi("words and 987"));
        Assert.Equal(int.MinValue, solution.MyAtoi("-91283472332"));
        Assert.Equal(0, solution.MyAtoi("+-12"));
        Assert.Equal(0, solution.MyAtoi("+"));
        Assert.Equal(int.MaxValue, solution.MyAtoi("21474836460"));
        Assert.Equal(0, solution.MyAtoi("00000-42a1234"));
        Assert.Equal(11, solution.MyAtoi("000000000000000000000000000011"));
        Assert.Equal(0, solution.MyAtoi("   +0 123"));
        Assert.Equal(-5, solution.MyAtoi("-5-"));
        Assert.Equal(0, solution.MyAtoi(" "));
    }
}