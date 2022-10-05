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
}