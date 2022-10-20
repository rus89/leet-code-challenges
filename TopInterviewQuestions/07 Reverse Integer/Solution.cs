using System.Text;

namespace TopInterviewQuestions._07_Reverse_Integer;

public class Solution
{
    public int Reverse(int x)
    {
        if (x is <= int.MinValue or >= int.MaxValue) return 0;
        var numbersStack = x > 0 ? RecursiveNumbers(x) : RecursiveNumbers(Math.Abs(x));
        StringBuilder stringBuilder = new StringBuilder();
        if (x < 0)
        {
            stringBuilder.Append('-');
        }

        foreach (var number in numbersStack)
        {
            stringBuilder.Append(number);
        }

        if (int.TryParse(stringBuilder.ToString(), out var numbersValue))
        {
            if (numbersValue is > int.MinValue and < int.MaxValue)
            {
                return numbersValue;
            }
        }

        return 0;
    }

    private Stack<int> RecursiveNumbers(int x)
    {
        if (x == 0) return new Stack<int>();

        var numbers = RecursiveNumbers(x / 10);
        numbers.Push(x % 10);
        return numbers;
    }
}