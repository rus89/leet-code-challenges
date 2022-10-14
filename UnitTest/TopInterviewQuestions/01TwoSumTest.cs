using System.Diagnostics;
using TopInterviewQuestions._01_Two_Sum;
using Xunit;

namespace UnitTest.TopInterviewQuestions;

public static class TwoSumTest
{
    [Fact]
    public static void TwoSumTester()
    {
        Solution solution = new Solution();
        Assert.Equal(new[] { 0, 1 }, solution.TwoSum(new[] { 2, 7, 11, 15 }, 9));
        Assert.Equal(new[] { 1, 2 }, solution.TwoSum(new[] { 3, 2, 4 }, 6));
        Assert.Equal(new[] { 0, 1 }, solution.TwoSum(new[] { 3, 3 }, 6));
        Assert.Equal(new[] { 0, 3 }, solution.TwoSum(new[] { 0, 4, 3, 0 }, 0));
        Assert.Equal(new[] { 2, 4 }, solution.TwoSum(new[] { -1, -2, -3, -4, -5 }, -8));
    }

    [Fact]
    public static void TwoSumLeetCodeTester()
    {
        Solution solution = new Solution();
        
        Assert.Equal(new[] { 0, 1 }, solution.TwoSumLeetCode(new[] { 2, 7, 11, 15 }, 9));
        Assert.Equal(new[] { 1, 2 }, solution.TwoSumLeetCode(new[] { 3, 2, 4 }, 6));
        Assert.Equal(new[] { 0, 1 }, solution.TwoSumLeetCode(new[] { 3, 3 }, 6));
        Assert.Equal(new[] { 0, 3 }, solution.TwoSumLeetCode(new[] { 0, 4, 3, 0 }, 0));
        Assert.Equal(new[] { 2, 4 }, solution.TwoSumLeetCode(new[] { -1, -2, -3, -4, -5 }, -8));
    }
}