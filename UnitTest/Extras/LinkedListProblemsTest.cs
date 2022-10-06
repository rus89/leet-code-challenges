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
}