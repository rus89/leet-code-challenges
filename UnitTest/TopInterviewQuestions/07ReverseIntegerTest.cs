using TopInterviewQuestions._07_Reverse_Integer;
using Xunit;

namespace UnitTest.TopInterviewQuestions;

public class ReverseIntegerTest
{
    [Fact]
    public static void ReverseIntegerTester()
    {
        Solution solution = new Solution();
        // Assert.Equal(321, solution.Reverse(123));
        // Assert.Equal(-321, solution.Reverse(-123));
        // Assert.Equal(21, solution.Reverse(120));
        Assert.Equal(0, solution.Reverse(-2147483648));
    }
}