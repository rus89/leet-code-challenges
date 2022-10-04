using Utilities;
using Xunit;
using Solution = TopInterviewQuestions._02_Add_Two_Numbers.Solution;

namespace UnitTest.TopInterviewQuestions;

public class AddTwoNumbersTest
{
    [Fact]
    public static void AddTwoNumbers()
    {
        Solution solution = new Solution();
        // Assert.Equal(new[] { 5, 0 }, solution.TestNullCoalescingOperator());

        ListNode ln1 = new ListNode(2, new ListNode(4, new ListNode(3)));
        ListNode ln2 = new ListNode(5, new ListNode(6, new ListNode(4)));
        ListNode actual = new ListNode(7, new ListNode(0, new ListNode(8)));
        Assert.Equal(solution.AddTwoNumbersLeetCode(ln1, ln2), actual);
        
        ListNode ln3 = new ListNode();
        ListNode ln4 = new ListNode();
        Assert.Equal(solution.AddTwoNumbersLeetCode(ln3, ln4), new ListNode());

        // Solution.ListNode ln5 = new Solution.ListNode(9,
        //     new Solution.ListNode(9,
        //         new Solution.ListNode(9,
        //             new Solution.ListNode(9,
        //                 new Solution.ListNode(9,
        //                     new Solution.ListNode(9,
        //                         new Solution.ListNode(9)))))));
        // Solution.ListNode ln6 = new Solution.ListNode(9,
        //     new Solution.ListNode(9,
        //         new Solution.ListNode(9,
        //             new Solution.ListNode(9))));
        // Assert.Equal(10009998, solution.AddTwoNumbers(ln5, ln6));
    }
}