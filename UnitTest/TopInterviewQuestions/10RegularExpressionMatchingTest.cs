using System.Text.RegularExpressions;
using TopInterviewQuestions._10_Regular_Expression_Matching;
using Xunit;

namespace UnitTest.TopInterviewQuestions;

public class RegularExpressionMatchingTest
{
    [Fact]
    public static void RegularExpressionMatchingTester()
    {
        // Assert.True(Regex.Match("aaaaaaaaaaa", ".").Success);
        Solution solution = new Solution();
        Assert.False(solution.IsMatch("", ""));
        Assert.False(solution.IsMatch(" ", " "));
        Assert.False(solution.IsMatch(" ", ""));
        Assert.False(solution.IsMatch("", " "));
        Assert.False(solution.IsMatch(" ", ".*"));
        Assert.False(solution.IsMatch("ABC", "ABC"));
        Assert.False(solution.IsMatch("abc123][=-=09r", "asdb.*09"));
        Assert.True(solution.IsMatch("zzzzzzzzzzz", "asdb.*"));
        Assert.False(solution.IsMatch("±!@#$%^&*()_+", ".*"));
        Assert.False(solution.IsMatch("aa", "a"));
        Assert.True(solution.IsMatch("aa", "a*"));
        Assert.True(solution.IsMatch("aa", ".*"));
        Assert.False(solution.IsMatch("abcdefghijklmnopqrstuvwxyz", ".*"));
        Assert.True(solution.IsMatch("zxy", "x*y*z*"));
        Assert.False(solution.IsMatch("abc", "x*y*z*"));
        Assert.True(solution.IsMatch("mnopqrstabs", "a.*"));
        Assert.True(solution.IsMatch("aaabaaabccc", "ab.*c*"));
        Assert.False(solution.IsMatch("aaaabbbaaaaccc", "abc*"));
        Assert.True(solution.IsMatch("r", "."));
        Assert.False(solution.IsMatch("aba", "cdefghijklmnopqrstyvwxyzcdefgh"));
        Assert.False(solution.IsMatch("aaabbbbcmnpqzzzz", "a.b.c.m.n."));
        Assert.True(solution.IsMatch("aabbccmmnn", "a.b.c.m.n."));
        Assert.True(solution.IsMatch("aaaazc", "a*.c"));
        Assert.False(solution.IsMatch("aaabzc", "a*.c"));
        Assert.True(solution.IsMatch("aaaaa", "....."));
        Assert.True(solution.IsMatch("aaaaaaaaaaa", "."));
        Assert.True(solution.IsMatch("a", "....."));
        Assert.True(solution.IsMatch("mps", "..."));
        Assert.False(solution.IsMatch("aabbcc", ".."));
        Assert.False(solution.IsMatch("abc", "."));
        Assert.True(solution.IsMatch("ab", ".*c"));
        Assert.True(solution.IsMatch("abc", "a.c"));
        Assert.False(solution.IsMatch("a c", "a.c"));
        Assert.False(solution.IsMatch("ac", "a.c"));
        Assert.False(solution.IsMatch("abbc", "a.c"));
    }
}