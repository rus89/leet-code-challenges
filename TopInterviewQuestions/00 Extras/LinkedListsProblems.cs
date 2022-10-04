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
}