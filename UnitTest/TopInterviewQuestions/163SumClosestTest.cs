using TopInterviewQuestions._16_3Sum_Closest;
using Xunit;

namespace UnitTest.TopInterviewQuestions;

public class ThreeSumClosestTest
{
    [Fact]
    public static void ThreeSumClosestTester()
    {
        Solution solution = new Solution();
        int expected = 2;
        Assert.Equal(expected, solution.ThreeSumClosest(new []{-1,2,1,-4}, 1));
        Assert.Equal(expected, solution.ThreeSumClosest(new []{1,1,1,0}, -100));
    }
}