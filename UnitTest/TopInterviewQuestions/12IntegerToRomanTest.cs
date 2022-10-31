using TopInterviewQuestions._12_Integer_to_Roman;
using Xunit;

namespace UnitTest.TopInterviewQuestions;

public class IntegerToRomanTest
{
    [Fact]
    public static void IntegerToRomanTester()
    {
        Solution solution = new Solution();
        Assert.Equal("III", solution.IntToRoman(3));
        Assert.Equal("LVIII", solution.IntToRoman(58));
        Assert.Equal("MCMXCIV", solution.IntToRoman(1994));
        Assert.Equal("CMXLIV", solution.IntToRoman(944));
        Assert.Equal("CDIV", solution.IntToRoman(404));
        Assert.Equal("XXII", solution.IntToRoman(22));
        Assert.Equal("CCII", solution.IntToRoman(202));
        Assert.Equal("DXLIX", solution.IntToRoman(549));
        Assert.Equal("MCMLXXXIX", solution.IntToRoman(1989));
        Assert.Equal("MCMXCIII", solution.IntToRoman(1993));
        Assert.Equal("MCMXLVIII", solution.IntToRoman(1948));
        Assert.Equal("MCMLIII", solution.IntToRoman(1953));
        Assert.Equal("MCMLXXII", solution.IntToRoman(1972));
        Assert.Equal("MMXVIII", solution.IntToRoman(2018));
        Assert.Equal("MMXXII", solution.IntToRoman(2022));
    }
}