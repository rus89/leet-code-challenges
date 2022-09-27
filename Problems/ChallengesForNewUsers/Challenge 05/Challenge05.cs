namespace Problems.Challenge_05;

public class Challenge05
{
    public class ListNode
    {
        public int val;
        public ListNode next;

        public ListNode(int val = 0, ListNode next = null)
        {
            this.val = val;
            this.next = next;
        }
    }

    public ListNode MiddleNode(ListNode head)
    {
        LinkedList<ListNode> linkedListNodes = new LinkedList<ListNode>();

        ListNode currentNode = head;
        while (currentNode != null)
        {
            linkedListNodes.AddLast(currentNode);
            currentNode = currentNode.next;
        }

        int capacity = linkedListNodes.Count;
        var newList = linkedListNodes.ToList();
        return newList[capacity / 2];
    }

    public ListNode MiddleNodeLeetCode(ListNode head)
    {
        ListNode slow = head, fast = head;
        while (fast != null && fast.next != null)
        {
            slow = slow.next;
            fast = fast.next.next;
        }

        return slow;
    }
}