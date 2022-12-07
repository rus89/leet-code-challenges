using Utilities;

namespace TopInterviewQuestions._19_Remove_Nth_Node_From_End_of_List;

public class Solution
{
    public ListNode RemoveNthFromEnd(ListNode head, int n)
    {
        // checking for a base case when we have only one element in the linked list
        // in that case n can be exactly 1 so we can return null for sure
        if (head.next == null) return null;
        
        // creating an auxiliary node to operate over the linked list
        ListNode currentNode = head;
        
        // creating a length variable so we can now how many elements are in the linked list
        // starting with 1 because we are sure there are more than 1 since the base case is passed
        int length = 1;
        
        // looping through the linked list calculating it's length
        while (currentNode.next != null)
        {
            length++;
            currentNode = currentNode.next;
        }

        // one more base case
        // if the length of the linked list is the same as n than you have to delete head node and return next nodes
        if (length == n)
        {
            return head.next;
        }

        // since you looped through the linked list to calculate it's length, currentNode is pointing to the last node and you have to reset it to the head
        currentNode = head;
        
        // looping through the linked list until you reach the length - n - 1 element since it's the element before the one you should delete from the list
        for (int i = 0; i < length - n - 1; i++, currentNode = currentNode.next) { }

        // deleting the desired node from the linked list by skipping it
        // this line works no matter if there is or there isn't node after the one you want to delete because
        // if there is the node after delete you point to it, and if not, than you point to null which is also valid and means you are at the end
        currentNode.next = currentNode.next.next;
        
        return head;
    }
}