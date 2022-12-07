namespace TopInterviewQuestions._20_Valid_Parentheses;

public class Solution
{
    public bool IsValid(string s)
    {
        var sLength = s.Length;

        // defining the stack because it works on LIFO (last in first out) principle which is very helpful here
        // because for every opened bracket we must have equivalent closed bracket and they must be closed in the correct order which we get with stack
        Stack<char> brackets = new Stack<char>();
        
        // looping through the input string and checking every single character if is equivalent with some type of opened brackets
        // if it is, than you push closed bracket on the stack
        // and if the element is the closed bracket, than, in the last if expression, you check if stack is empty or
        // you get the char on the top and remove it from the stack, and
        // if the char on the top of stack is different than the type of closing bracket you are asking for
        // that means some of the rules is not satisfied and you return false
        // i.e if string starts with "}" the algorithm drop you on the last else if branch and tell you that there is no elements in the stack and return false
        // 2. i.e if string is "{[}" the algorithm adds '}' on the stack after the first char ('{') and ']' after the second
        // but when you get to the 3. element you get the char from the top of stack and on the top is ']' which is different than '}' and return false
        for (int i = 0; i < sLength; i++)
        {
            if (s[i].Equals('('))
            {
                brackets.Push(')');
            }
            else if (s[i].Equals('['))
            {
                brackets.Push(']');
            }
            else if (s[i].Equals('{'))
            {
                brackets.Push('}');
            }
            else if (brackets.Count == 0 || brackets.Pop() != s[i])
            {
                return false;
            }
        }

        // at the end stack should have 0 elements
        return brackets.Count == 0;
    }
}