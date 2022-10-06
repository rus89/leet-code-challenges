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

    public bool IsPalindrome(ListNode head)
    {
        if (head == null || head.next == null) return true;

        List<int> list = new List<int>();
        while (head != null)
        {
            list.Add(head.val);
            head = head.next;
        }

        for (int i = 0; i < list.Count / 2; ++i)
        {
            if (list[i] != list[list.Count - i - 1])
            {
                return false;
            }
        }

        return true;
    }

    public bool IsPureLinkedListPalindrome(ListNode head)
    {
        if (head == null || head.next == null) return true;

        ListNode slow = head;
        ListNode fast = head.next;
        while (fast != null && fast.next != null) //split into two halves while the first half can be one-node longer
        {
            slow = slow.next;
            fast = fast.next.next;
        }

        fast = slow.next;
        slow.next = null!;
        ListNode newHead = new ListNode(); //reverse the second half
        ListNode lastInSecondHalf = fast;
        while (lastInSecondHalf != null)
        {
            var next = lastInSecondHalf.next;
            lastInSecondHalf.next = newHead.next;
            newHead.next = lastInSecondHalf;
            lastInSecondHalf = next;
        }

        fast = newHead.next; //compare the two lists
        while (fast != null)
        {
            if (fast.val != head.val)
            {
                return false;
            }

            fast = fast.next;
            head = head.next;
        }

        return fast == null;
    }

    public ListNode RotateToTheRight(ListNode head, int k)
    {
        if (head == null) return head;

        int length = 1;
        ListNode last = head;
        while (last.next != null)
        {
            length++;
            last = last.next;
        }

        last.next = head;
        if (k == k % length)
        {
            for (int i = 0; i < length - k; i++, last = last.next)
            {
            }
        }

        ListNode newHead = last.next;
        last.next = null;
        return newHead;
    }
}