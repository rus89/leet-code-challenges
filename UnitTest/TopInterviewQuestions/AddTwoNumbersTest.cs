using TopInterviewQuestions._02_Add_Two_Numbers;
using Xunit;

namespace UnitTest.TopInterviewQuestions;

public class AddTwoNumbersTest
{
    [Fact]
    public static void AddTwoNumbers()
    {
        Solution solution = new Solution();
        // Assert.Equal(new[] { 5, 0 }, solution.TestNullCoalescingOperator());

        Solution.ListNode ln1 = new Solution.ListNode(2, new Solution.ListNode(4, new Solution.ListNode(3)));
        Solution.ListNode ln2 = new Solution.ListNode(5, new Solution.ListNode(6, new Solution.ListNode(4)));
        Solution.ListNode actual = new Solution.ListNode(7, new Solution.ListNode(0, new Solution.ListNode(8)));
        Assert.Equal(solution.AddTwoNumbersLeetCode(ln1, ln2), actual);
        
        Solution.ListNode ln3 = new Solution.ListNode();
        Solution.ListNode ln4 = new Solution.ListNode();
        Assert.Equal(solution.AddTwoNumbersLeetCode(ln3, ln4), new Solution.ListNode());

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