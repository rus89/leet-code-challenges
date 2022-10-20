using TopInterviewQuestions._06_Zigzag_Conversion;
using Xunit;

namespace UnitTest.TopInterviewQuestions;

public class ZigzagConversionTest
{
    [Fact]
    public static void ZigzagConversionTester()
    {
        Solution solution = new Solution();
        Assert.Equal("PAHNAPLSIIGYIR", solution.Convert("PAYPALISHIRING", 3));
    }
}