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
        ListNode expected = new ListNode(7, new ListNode(0, new ListNode(8)));
        Assert.Equivalent(expected, solution.AddTwoNumbersLeetCode(ln1, ln2));
        
        ListNode ln3 = new ListNode();
        ListNode ln4 = new ListNode();
        Assert.Equivalent(new ListNode(), solution.AddTwoNumbersLeetCode(ln3, ln4));

        ListNode ln5 = new ListNode(9,
            new ListNode(9,
                new ListNode(9,
                    new ListNode(9,
                        new ListNode(9,
                            new ListNode(9,
                                new ListNode(9)))))));
        ListNode ln6 = new ListNode(9,
            new ListNode(9,
                new ListNode(9,
                    new ListNode(9))));
        ListNode expected1 = new ListNode(8,
            new ListNode(9,
                new ListNode(9,
                    new ListNode(9,
                        new ListNode(0,
                            new ListNode(0,
                                new ListNode(0,
                                    new ListNode(1))))))));
        Assert.Equivalent(expected1, solution.AddTwoNumbersLeetCode(ln5, ln6));
    }
}