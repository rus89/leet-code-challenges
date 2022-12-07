using Utilities;

namespace TopInterviewQuestions._21_Merge_Two_Sorted_Lists;

public class Solution
{
    public ListNode MergeTwoLists(ListNode list1, ListNode list2)
    {
        if (list1 == null && list2 == null) return null;
        if (list1 == null) return list2;
        if (list2 == null) return list1;

        ListNode newHead = new ListNode();
        ListNode currentNode = newHead;
        while (list1 != null && list2 != null)
        {
            if (list1.val <= list2.val)
            {
                currentNode.next = list1;
                list1 = list1.next;
            }
            else
            {
                currentNode.next = list2;
                list2 = list2.next;
            }

            currentNode = currentNode.next;
        }

        currentNode.next = list1 == null ? list2 : list1;
        return newHead.next;
    }
}