using System.Text;

namespace TopInterviewQuestions._08_String_to_Integer__atoi_;

public class Solution
{
    public int MyAtoi(string s)
    {
        var sLength = s.Length;
        if (sLength == 0 || string.IsNullOrEmpty(s) || string.IsNullOrWhiteSpace(s)) return 0;
        const char minusSign = '-';
        const char plusSign = '+';
        int i = 0;
        int sign = 1;
        StringBuilder stringBuilder = new StringBuilder();
        for (; i < sLength && s[i] == ' '; i++)
        {
        }

        if (s[i] == minusSign || s[i] == plusSign)
        {
            sign = s[i] == plusSign ? 1 : -1;
            ++i;
        }

        for (; i < sLength; i++)
        {
            var currentChar = s[i];
            if (int.TryParse(currentChar.ToString(), out var result))
            {
                stringBuilder.Append(result);
            }
            else if (stringBuilder.Length > 0) break;
            else return 0;
        }

        if (int.TryParse(stringBuilder.ToString(), out var finalInteger))
        {
            if (sign == -1) return -finalInteger;
            return finalInteger;
        }

        return sign switch
        {
            -1 when stringBuilder.Length > 0 => int.MinValue,
            1 when stringBuilder.Length > 0 => int.MaxValue,
            _ => 0
        };
    }

    public int MyAtoiLeetCode(string str)
    {
        int index = 0, sign = 1, total = 0;
        //1. Empty string
        if (str.Length == 0) return 0;

        //2. Remove Spaces
        while (str[index] == ' ' && index < str.Length)
            index++;

        //3. Handle signs
        if (str[index] == '+' || str[index] == '-')
        {
            sign = str[index] == '+' ? 1 : -1;
            index++;
        }

        //4. Convert number and avoid overflow
        while (index < str.Length)
        {
            int digit = str[index] - '0';
            if (digit < 0 || digit > 9) break;

            //check if total will be overflow after 10 times and add digit
            if (int.MaxValue / 10 < total || int.MaxValue / 10 == total && int.MaxValue % 10 < digit)
                return sign == 1 ? int.MaxValue : int.MinValue;

            total = 10 * total + digit;
            index++;
        }

        return total * sign;
    }
}