using TopInterviewQuestions._19_Remove_Nth_Node_From_End_of_List;
using Utilities;
using Xunit;

namespace UnitTest.TopInterviewQuestions;

public class RemoveNthNodeFromEndOfListTest
{
    [Fact]
    public static void RemoveNthNodeFromEndOfListTester()
    {
        Solution solution = new Solution();
        ListNode expected = new ListNode(1, new ListNode(2, new ListNode(3, new ListNode(5))));
        ListNode head = new ListNode(1, new ListNode(2, new ListNode(3, new ListNode(4, new ListNode(5)))));
        Assert.Equivalent(expected, solution.RemoveNthFromEnd(head, 2));
        expected = null;
        head = new ListNode(1);
        Assert.Equivalent(expected, solution.RemoveNthFromEnd(head, 1));
        expected = new ListNode(1);
        head = new ListNode(1, new ListNode(2));
        Assert.Equivalent(expected, solution.RemoveNthFromEnd(head, 1));
        expected = new ListNode(3, new ListNode(2, new ListNode(1, new ListNode(1, new ListNode(2, new ListNode(3))))));
        head = new ListNode(3, new ListNode(2, new ListNode(1, new ListNode(0, new ListNode(1, new ListNode(2, new ListNode(3)))))));
        Assert.Equivalent(expected, solution.RemoveNthFromEnd(head, 4));
        expected = new ListNode(2);
        head = new ListNode(1, new ListNode(2));
        Assert.Equivalent(expected, solution.RemoveNthFromEnd(head, 2));
    }
}