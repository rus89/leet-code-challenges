using TopInterviewQuestions._14_Longest_Common_Prefix;
using Xunit;

namespace UnitTest.TopInterviewQuestions;

public class LongestCommonPrefixTest
{
    [Fact]
    public static void LongestCommonPrefixTester()
    {
        Solution solution = new Solution();
        Assert.Equal("fl", solution.LongestCommonPrefix(new[] { "flower", "flow", "flight" }));
        Assert.Equal("", solution.LongestCommonPrefix(new[] { "dog", "racecar", "car" }));
        Assert.Equal("", solution.LongestCommonPrefix(new[] { "dog", "hog", "bog", "mog" }));
        Assert.Equal("flow",
            solution.LongestCommonPrefix(new[]
                { "flow", "flow", "flow", "flow", "flow", "flow", "flow", "flow", "flow", "flow", "flow", "flow", "flow", "flow" }));
        Assert.Equal("f", solution.LongestCommonPrefix(new[] { "f", "fl", "flo", "flow", "flowe", "flower" }));
        Assert.Equal("f", solution.LongestCommonPrefix(new[] { "flower", "flowe", "flow", "flo", "fl", "f" }));
        Assert.Equal("", solution.LongestCommonPrefix(new[]
        {
            "Lorem", "ipsum", "dolor", "sit", "amet", "consectetur", "adipisicing", "elit",
            "sed", "do", "eiusmod", "tempor", "incididunt", "ut", "labore", "et", "dolore", "magna", "aliqua", "Ut", "enim", "ad", "minim", "veniam",
            "quis", "nostrud", "exercitation", "ullamco", "laboris", "nisi", "ut", "aliquip", "ex", "ea", "commodo", "consequat", "Duis", "aute",
            "irure", "dolor", "in", "reprehenderit", "in", "voluptate",
            "velit", "esse", "cillum", "dolore", "eu", "fugiat", "nulla", "pariatur", "Excepteur", "sint", "occaecat", "cupidatat", "non", "proident",
            "sunt", "in", "culpa", "qui", "officia", "deserunt", "mollit", "anim", "id", "est", "laborum"
        }));
        Assert.Equal("dog", solution.LongestCommonPrefix(new[] { "dog" }));
        Assert.Equal("aba", solution.LongestCommonPrefix(new[] { "aba" }));
        Assert.Equal("anavolimolovana", solution.LongestCommonPrefix(new[] { "anavolimolovana" }));
        Assert.Equal("", solution.LongestCommonPrefix(new[] { "a", "a", "ana", "ann", "aspirin", "" }));
        Assert.Equal("", solution.LongestCommonPrefix(new[] { "aba is baba", "baba is aba", "shit is droped" }));
        Assert.Equal("", solution.LongestCommonPrefix(new[] { "a", "!@#$%^&*(", "123" }));
        Assert.Equal("", solution.LongestCommonPrefix(new[] { "1234", "anna", "ann", "An", "A" }));
        Assert.Equal("", solution.LongestCommonPrefix(new[] { "flower", "rewolf" }));
        Assert.Equal("", solution.LongestCommonPrefix(new[] { "aba is baba", "aba is baba", "aba is baba" }));
        Assert.Equal("", solution.LongestCommonPrefix(new[] { "" }));
        Assert.Equal("", solution.LongestCommonPrefix(new[] { "aba is baba", "aba is", "aba" }));
        Assert.Equal("", solution.LongestCommonPrefix(new[] { "dog", "racecar", "car" }));
    }
}