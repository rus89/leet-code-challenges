namespace TopInterviewQuestions._17_Letter_Combinations_of_a_Phone_Number;

public class Solution
{
    public IList<string> LetterCombinations(string digits)
    {
        // the list with all the result
        List<string> result = new List<string>();
        
        // checking for a base case scenario if input string "digits" is empty string
        // in that case we should return empty list
        if (string.IsNullOrEmpty(digits)) return result;
        
        // this is a hardcode solution to map all digits into letters
        Dictionary<char, string> mapping = new Dictionary<char, string>
        {
            { '2', "abc" }, { '3', "def" }, { '4', "ghi" }, { '5', "jkl" }, { '6', "mno" }, { '7', "pqrs" }, { '8', "tuv" }, { '9', "wxyz" }
        };
        
        // here I'm calling a backtrack method to solve the problem
        // params are input string of the main method, list of results, map, and currentString
        // current string represents a string we are building through the time and adding it to the list of results
        BacktrackingMethod(digits, result, mapping, "");
        
        // returning the list with results
        return result;
}

    private void BacktrackingMethod(string digits, ICollection<string> result, IReadOnlyDictionary<char, string> mapping, string currentString)
    {
        // since this is recursive method, you have to have an exit point and this is one
        // when you draw a backtracking tree you see that the length of every single solution in the list of solutions is the same as the length of input string "digits"
        // that's what you are checking here
        if (currentString.Length == digits.Length)
        {
            // and if the condition is satisfied, you add it to the result list and return
            result.Add(currentString);
            return;
        }

        // you have to get the character of the current digit in order to build a single solution
        // by the time, with every new call of a BacktrackingMethod you increase currentString.Length which is used here as index,
        // and that means you are moving to the next digit in the "digits" string before writing down all characters from the current digit 
        var currentDigitCharacters = mapping[digits[currentString.Length]];
        
        // than you are looping through all characters for one digit and call method recursively with new params 
        for (int i = 0; i < currentDigitCharacters.Length; i++)
        {
            // here you are concatenating you currentString with new character and call a method again until you get desired result
            BacktrackingMethod(digits, result, mapping, currentString + currentDigitCharacters[i]);
        }
    }
}