using TopInterviewQuestions._17_Letter_Combinations_of_a_Phone_Number;
using Xunit;

namespace UnitTest.TopInterviewQuestions;

public class LetterCombinationsOfAPhoneNumber
{
    [Fact]
    public static void LetterCombinationsOfAPhoneNumberTester()
    {
        Solution solution = new Solution();
        string[] expected = { "ad", "ae", "af", "bd", "be", "bf", "cd", "ce", "cf" };
        Assert.Equal(expected, solution.LetterCombinations("23"));
        expected = Array.Empty<string>();
        Assert.Equal(expected, solution.LetterCombinations(""));
        expected = new[] { "a", "b", "c" };
        Assert.Equal(expected, solution.LetterCombinations("2"));
    }
    
}