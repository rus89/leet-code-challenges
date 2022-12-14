namespace TopInterviewQuestions._22_Generate_Parentheses;

public class Solution
{
    public IList<string> GenerateParenthesis(int n)
    {
        // generating the list that will contains all particular solutions
        List<string> result = new List<string>();
        
        // this is a problem that at first I saw as a problem where backtracking would be one of solution
        // recursive technique is the most obvious solution for backtracking problems for me at the moment
        // generating recursive method which will take currentString as a particular solution, number of left "(" and right ")" parenthesis and result list
        // first call of this method is of course with empty currentString because we didn't generate it yet
        GenerateParenthesisInternal("", n, n, result);

        return result;
    }

    private void GenerateParenthesisInternal(string currentString, int leftParenthesisRemainder, int rightParenthesisRemainder, List<string> result)
    {
        // general condition for breaking the infinite loop in recursive method is if the number of remained left and right parenthesis is 0
        // it is also the sign that one particular solution is generated
        if (leftParenthesisRemainder == 0 && rightParenthesisRemainder == 0)
        {
            result.Add(currentString);
            return;
        }

        // on the other side, if we are still searching for a valid solution we have to check next
        // if the number of left parenthesis is greater than 0 than we are adding left parenthesis to the current string, reduce the number of remaining
        // left parenthesis for 1, while the number of the right parenthesis stays the same and call the function again to go deeper and generate solitons
        if (leftParenthesisRemainder > 0)
        {
            GenerateParenthesisInternal(currentString + "(", leftParenthesisRemainder - 1, rightParenthesisRemainder, result);
        }

        // other condition for valid solution to generate is that remaining number of right parenthesis be greater than 0 and greater than number of
        // remaining left parenthesis
        if (rightParenthesisRemainder > 0 && rightParenthesisRemainder > leftParenthesisRemainder)
        {
            GenerateParenthesisInternal(currentString + ")", leftParenthesisRemainder, rightParenthesisRemainder - 1, result);
        }
    }
}