using Utilities;

namespace ChallengesForNewUsers.Challenge_02;

public class PalindromeLinkedList
{
    /*
     * trenutno me najvise muci to sto kazu da daju head linkovane liste, a onda u primeru dole stoji [1,2,2,1]
     * sto nije head vec cela lista
     * head treba da bude samo prvi el liste
     * a tail je zadnji elemenat liste i on je jedini koji nema referencu na sledeci objekat, tj ta referenca je null
     * i sad cela ta zajebancija u meni stvara rascep mozga da ne mogu da se sastavim
     */
    
    public bool IsPalindrome(ListNode head)
    {
        List<int> values = new List<int>();

        ListNode currentNode = head;
        while (currentNode != null)
        {
            values.Add(currentNode.val);
            currentNode = currentNode.next;
        }

        int front = 0;
        int back = values.Count - 1;
        while (front < back)
        {
            if (values[front] != values[back])
            {
                return false;
            }
            front++;
            back--;
        }
        
        return true;
    }
}