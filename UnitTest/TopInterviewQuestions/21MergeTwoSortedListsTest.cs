using TopInterviewQuestions._21_Merge_Two_Sorted_Lists;
using Utilities;
using Xunit;

namespace UnitTest.TopInterviewQuestions;

public class MergeTwoSortedListsTest
{
    [Fact]
    public static void MergeTwoSortedListsTester()
    {
        Solution solution = new Solution();
        ListNode headOne = new ListNode(1, new ListNode(2, new ListNode(4)));
        ListNode headTwo = new ListNode(1, new ListNode(3, new ListNode(4)));
        ListNode expected = new ListNode(1, new ListNode(1, new ListNode(2, new ListNode(3, new ListNode(4, new ListNode(4))))));
        Assert.Equivalent(expected, solution.MergeTwoLists(headOne, headTwo));
    }
}