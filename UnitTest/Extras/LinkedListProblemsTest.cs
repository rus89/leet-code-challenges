using TopInterviewQuestions._00_Extras;
using Utilities;
using Xunit;

namespace UnitTest.Extras;

public class LinkedListProblemsTest
{
    [Fact]
    public static void DoesItRemoveDuplicates()
    {
        LinkedListsProblems linkedListsProblems = new LinkedListsProblems();
        
        ListNode ln1 = new ListNode(1, new ListNode(1, new ListNode(2)));
        ListNode expected1 = new ListNode(1, new ListNode(2));
        Assert.Equivalent(expected1, linkedListsProblems.DeleteDuplicates(ln1));

        ListNode ln2 = new ListNode(1, new ListNode(1, new ListNode(2, new ListNode(3, new ListNode(3)))));
        ListNode expected2 = new ListNode(1, new ListNode(2, new ListNode(3)));
        Assert.Equivalent(expected2, linkedListsProblems.DeleteDuplicates(ln2));
        
        ListNode ln3 = new ListNode(1, new ListNode(1, new ListNode(1, new ListNode(1, new ListNode(1)))));
        ListNode expected3 = new ListNode(1);
        Assert.Equivalent(expected3, linkedListsProblems.DeleteDuplicates(ln3));
    }

    [Fact]
    public static void DoesItRemoveDuplicatesExample2()
    {
        LinkedListsProblems linkedListsProblems = new LinkedListsProblems();
        
        ListNode ln1 = new ListNode(1, new ListNode(1, new ListNode(2)));
        ListNode expected1 = new ListNode(2);
        Assert.Equivalent(expected1, linkedListsProblems.DeleteAllDuplicateNodesIterative(ln1));

        ListNode ln2 = new ListNode(1, new ListNode(1, new ListNode(2, new ListNode(3, new ListNode(3)))));
        ListNode expected2 = new ListNode(2);
        Assert.Equivalent(expected2, linkedListsProblems.DeleteAllDuplicateNodesIterative(ln2));
        
        ListNode ln3 = new ListNode(1, new ListNode(1, new ListNode(1, new ListNode(1, new ListNode(1)))));
        Assert.Equivalent(null, linkedListsProblems.DeleteAllDuplicateNodesIterative(ln3));
    }

    [Fact]
    public static void DoesItRemoveAllDuplicateNodesRecursive()
    {
        LinkedListsProblems linkedListsProblems = new LinkedListsProblems();
        
        ListNode actual = null!;
        ListNode expected = null;
        Assert.Equivalent(expected, linkedListsProblems.DeleteAllDuplicateNodesRecursive(actual));
        
        ListNode actual1 = new ListNode();
        ListNode expected1 = new ListNode();
        Assert.Equivalent(expected1, linkedListsProblems.DeleteAllDuplicateNodesRecursive(actual1));
        
        ListNode actual2 = new ListNode(1, new ListNode(1, new ListNode(2)));
        ListNode expected2 = new ListNode(2);
        Assert.Equivalent(expected2, linkedListsProblems.DeleteAllDuplicateNodesRecursive(actual2));
        
        ListNode actual3 = new ListNode(1, new ListNode(1, new ListNode(2, new ListNode(3, new ListNode(3)))));
        ListNode expected3 = new ListNode(2);
        Assert.Equivalent(expected3, linkedListsProblems.DeleteAllDuplicateNodesRecursive(actual3));
        
        ListNode actual4 = new ListNode(1, new ListNode(1, new ListNode(1, new ListNode(1, new ListNode(1)))));
        ListNode expected4 = new ListNode(1);
        Assert.Equivalent(expected4, linkedListsProblems.DeleteAllDuplicateNodesRecursive(actual4));
        
        ListNode actual5 = new ListNode(1, new ListNode(2, new ListNode(3, new ListNode(4, new ListNode(4)))));
        ListNode expected5 = new ListNode(1, new ListNode(2, new ListNode(3)));
        Assert.Equivalent(expected5, linkedListsProblems.DeleteAllDuplicateNodesRecursive(actual5));
    }

    [Fact]
    public static void IsItPalindromeList()
    {
        LinkedListsProblems linkedListsProblems = new LinkedListsProblems();
        
        ListNode actual = new ListNode(1, new ListNode(2, new ListNode(3, new ListNode(2, new ListNode(1)))));
        Assert.True(linkedListsProblems.IsPalindrome(actual));
        
        ListNode actual1 = new ListNode(1, new ListNode(1, new ListNode(1, new ListNode(1, new ListNode(2)))));
        Assert.False(linkedListsProblems.IsPalindrome(actual1));
        
        ListNode actual2 = new ListNode(1, new ListNode(1, new ListNode(1, new ListNode(1, new ListNode(1)))));
        Assert.True(linkedListsProblems.IsPalindrome(actual2));
    }

    [Fact]
    public static void IsItPureLinkedListPalindrome()
    {
        LinkedListsProblems linkedListsProblems = new LinkedListsProblems();
        
        ListNode actual = new ListNode(1, new ListNode(2, new ListNode(3, new ListNode(2, new ListNode(1)))));
        Assert.True(linkedListsProblems.IsPureLinkedListPalindrome(actual));
        
        ListNode actual1 = new ListNode(1, new ListNode(1, new ListNode(1, new ListNode(1, new ListNode(2)))));
        Assert.False(linkedListsProblems.IsPureLinkedListPalindrome(actual1));
        
        ListNode actual2 = new ListNode(1, new ListNode(1, new ListNode(1, new ListNode(1, new ListNode(1)))));
        Assert.True(linkedListsProblems.IsPureLinkedListPalindrome(actual2));
    }

    [Fact]
    public static void DoesItRotateLinkedListToTheRight()
    {
        LinkedListsProblems linkedListsProblems = new LinkedListsProblems();
        
        ListNode actual = new ListNode(1, new ListNode(2, new ListNode(3, new ListNode(4, new ListNode(5)))));
        ListNode expected = new ListNode(4, new ListNode(5, new ListNode(1, new ListNode(2, new ListNode(3)))));
        Assert.Equivalent(expected, linkedListsProblems.RotateToTheRight(actual, 2));
        
        ListNode actual1 = new ListNode(1, new ListNode(2, new ListNode(3, new ListNode(4, new ListNode(5)))));
        ListNode expected1 = new ListNode(3, new ListNode(4, new ListNode(5, new ListNode(1, new ListNode(2)))));
        Assert.Equivalent(expected1, linkedListsProblems.RotateToTheRight(actual1, 3));
        
        ListNode actual2 = null;
        ListNode expected2 = actual2;
        Assert.Equivalent(expected2, linkedListsProblems.RotateToTheRight(actual2, 2));
        
        ListNode actual3 = new ListNode(1, new ListNode(1, new ListNode(3, new ListNode(5, new ListNode(5)))));
        ListNode expected3 = new ListNode(1, new ListNode(3, new ListNode(5, new ListNode(5, new ListNode(1)))));
        Assert.Equivalent(expected3, linkedListsProblems.RotateToTheRight(actual3, 4));
        
        ListNode actual4 = new ListNode(1, new ListNode(2, new ListNode(3, new ListNode(4, new ListNode(5)))));
        ListNode expected4 = new ListNode(1, new ListNode(2, new ListNode(3, new ListNode(4, new ListNode(5)))));
        Assert.Equivalent(expected4, linkedListsProblems.RotateToTheRight(actual4, 5));
        
        ListNode actual5 = new ListNode(1, new ListNode(2, new ListNode(3)));
        ListNode expected5 = new ListNode(3, new ListNode(1, new ListNode(2)));
        Assert.Equivalent(expected5, linkedListsProblems.RotateToTheRight(actual5, 1));
    }

    [Fact]
    public static void DoesItReverseLinkedListBetweenMAndN()
    {
        LinkedListsProblems linkedListsProblems = new LinkedListsProblems();

        ListNode actual = new ListNode(1, new ListNode(2, new ListNode(3, new ListNode(4, new ListNode(5)))));
        ListNode expected = new ListNode(1, new ListNode(4, new ListNode(3, new ListNode(2, new ListNode(5)))));
        const int m = 2, n = 4;
        Assert.Equivalent(expected, linkedListsProblems.ReverseBetween(actual, m, n));
    }

    [Fact]
    public static void IsThereCycleInLinkedList()
    {
        LinkedListsProblems linkedListsProblems = new LinkedListsProblems();

        ListNode second = null;
        second = new ListNode(2, new ListNode(0, new ListNode(-4, second)));
        ListNode actual = new ListNode(3, second);
        Assert.True(linkedListsProblems.DetectCycle(actual) != null);

        ListNode actual1 = new ListNode(1);
        Assert.True(linkedListsProblems.DetectCycle(actual1) == null);
    }
}