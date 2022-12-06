using TopInterviewQuestions._18_4Sum;
using Xunit;

namespace UnitTest.TopInterviewQuestions;

public class SumTest
{
    [Fact]
    public static void FourSumTester()
    {
        Solution solution = new Solution();
        IList<IList<int>> expected = new List<IList<int>>();
        expected.Add(new[] { -2, -1, 1, 2 });
        expected.Add(new[] { -2, 0, 0, 2 });
        expected.Add(new[] { -1, 0, 0, 1 });
        Assert.Equal(expected, solution.FourSum(new[] { 1, 0, -1, 0, -2, 2 }, 0));
        expected.Clear();
        expected.Add(new[] { 2, 2, 2, 2 });
        Assert.Equal(expected, solution.FourSum(new[] { 2, 2, 2, 2, 2 }, 8));
        expected.Clear();
        Assert.Equal(expected, solution.FourSum(new[] { 1000000000, 1000000000, 1000000000, 1000000000 }, -294967296));
    }
}