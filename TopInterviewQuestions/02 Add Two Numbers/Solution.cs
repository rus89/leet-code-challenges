namespace TopInterviewQuestions._02_Add_Two_Numbers;

public class Solution
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

    public ListNode AddTwoNumbers(ListNode l1, ListNode l2)
    {
        ListNode currentNode = l1;
        var number = ExtractNumber(currentNode);
        currentNode = l2;
        number += ExtractNumber(currentNode);
        var numbers = NumbersIn(number);
        if (numbers.Count == 0)
        {
            return new ListNode();
        }

        ListNode returnNode = null;
        int counter = 0;
        while (numbers.TryPop(out var result))
        {
            counter++;
            currentNode.val = result;
            if (counter == 1)
            {
                returnNode = currentNode;
            }

            currentNode = currentNode.next;
        }

        return returnNode;
    }

    private int ExtractNumber(ListNode currentNode)
    {
        int power = 0;
        int number = 0;
        while (currentNode != null)
        {
            number += (int)(currentNode.val * Math.Pow(10, power));
            ++power;
            currentNode = currentNode.next;
        }

        return number;
    }

    private Stack<int> NumbersIn(int value)
    {
        if (value == 0) return new Stack<int>();
        var numbers = NumbersIn(value / 10);
        numbers.Push(value % 10);
        return numbers;
    }

    public ListNode AddTwoNumbersLeetCode(ListNode l1, ListNode l2)
    {
        ListNode previous = new ListNode();
        ListNode head = previous;
        int carry = 0;
        while (l1 != null || l2 != null || carry != 0)
        {
            ListNode current = new ListNode();
            int sum = (l2?.val ?? 0) + (l1?.val ?? 0) + carry;
            current.val = sum % 10;
            carry = sum / 10;
            previous.next = current;
            previous = current;

            l1 = l1 == null ? l1 : l1.next;
            l2 = l2 == null ? l2 : l2.next;
        }

        return head.next;
    }
}