using TopInterviewQuestions._04_Median_of_Two_Sorted_Arrays;
using Xunit;

namespace UnitTest.TopInterviewQuestions;

public class MedianOfTwoSortedArraysTest
{
    [Fact]
    public static void MedianOfTwoSortedArraysTester()
    {
        Solution solution = new Solution();
        // my solution testing
        Assert.Equal(2d, solution.FindMedianSortedArrays(new[] { 1, 3 }, new[] { 2 }));
        Assert.Equal(2.5d, solution.FindMedianSortedArrays(new[] { 1, 2 }, new[] { 3, 4 }));
        Assert.Equal(2.5d, solution.FindMedianSortedArrays(new[] { 1, 3 }, new[] { 2, 7 }));
        Assert.Equal(2.5d, solution.FindMedianSortedArrays(new[] { 1, 2, 7 }, new[] { 3 }));
        Assert.Equal(1d, solution.FindMedianSortedArrays(new[] { 1, 1 }, new[] { 1, 2 }));
        Assert.Equal(11d, solution.FindMedianSortedArrays(new[] { 1, 3, 8, 9, 15 }, new[] { 7, 11, 18, 19, 21, 25 }));
        // leet code solution testing
        Assert.Equal(2d, solution.FindMedianSortedArraysLeetCode(new[] { 1, 3 }, new[] { 2 }));
        Assert.Equal(2.5d, solution.FindMedianSortedArraysLeetCode(new[] { 1, 2 }, new[] { 3, 4 }));
        Assert.Equal(2.5d, solution.FindMedianSortedArraysLeetCode(new[] { 1, 3 }, new[] { 2, 7 }));
        Assert.Equal(2.5d, solution.FindMedianSortedArraysLeetCode(new[] { 1, 2, 7 }, new[] { 3 }));
        Assert.Equal(1d, solution.FindMedianSortedArraysLeetCode(new[] { 1, 1 }, new[] { 1, 2 }));
        Assert.Equal(11d, solution.FindMedianSortedArraysLeetCode(new[] { 1, 3, 8, 9, 15 }, new[] { 7, 11, 18, 19, 21, 25 }));
    }
}