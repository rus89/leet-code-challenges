namespace TopInterviewQuestions._09_Palindrome_Number;

public class Solution
{
    public bool IsPalindrome(int x)
    {
        switch (x)
        {
            case <= int.MinValue or >= int.MaxValue:
                return false;
            case 0:
                return true;
        }

        List<int> numbers = new List<int>();
        for (int i = x; i > 0; i /= 10)
        {
            numbers.Add(i % 10);
        }

        if (numbers.Count == 0) return false;
        int front = 0;
        int back = numbers.Count - 1;
        while (front < back)
        {
            if (numbers[front] != numbers[back]) return false;
            front++;
            back--;
        }

        return true;
    }
}