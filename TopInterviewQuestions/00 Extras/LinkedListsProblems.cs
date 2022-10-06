using Utilities;

namespace TopInterviewQuestions._00_Extras;

public class LinkedListsProblems
{
    public ListNode DeleteDuplicates(ListNode head)
    {
        ListNode currentNode = head;
        ListNode nextNode = head.next;
        int headValue = head.val;
        while (nextNode != null)
        {
            if (headValue != nextNode.val)
            {
                currentNode.next = nextNode;
                headValue = nextNode.val;
                currentNode = currentNode.next;
            }

            nextNode = nextNode.next;
        }

        currentNode.next = null;
        return head;
    }

    public ListNode DeleteAllDuplicateNodesIterative(ListNode head)
    {
        ListNode dummy = new ListNode
        {
            next = head
        };
        ListNode currentNode = dummy;
        while (currentNode.next != null && currentNode.next.next != null)
        {
            if (currentNode.next.val == currentNode.next.next.val)
            {
                var duplicate = currentNode.next.val;
                while (currentNode.next != null && currentNode.next.val == duplicate)
                {
                    currentNode.next = currentNode.next.next;
                }
            }
            else
            {
                currentNode = currentNode.next;
            }
        }

        return dummy.next;
    }

    public ListNode DeleteAllDuplicateNodesRecursive(ListNode head)
    {
        if (head == null) return null;
        if (head.next == null) return head;
        int headValue = head.val;
        ListNode nextNode = head.next;
        if (nextNode.val != headValue)
        {
            head.next = DeleteAllDuplicateNodesRecursive(nextNode);
            return head;
        }

        while (nextNode != null && nextNode.val == headValue)
        {
            nextNode = nextNode.next;
            return DeleteAllDuplicateNodesRecursive(nextNode);
        }

        return null!;
    }
}