using TopInterviewQuestions._05_Longest_Palindromic_Substring;
using Xunit;

namespace UnitTest.TopInterviewQuestions;

public class LongestPalindromicSubstringTest
{
    [Fact]
    public static void LongestPalindromicSubstringTester()
    {
        Solution solution = new Solution();
        const string actual2 = "babad";
        Assert.Equal("aba", solution.LongestPalindrome(actual2));
        
        const string actual3 = "cbbd";
        Assert.Equal("bb", solution.LongestPalindrome(actual3));
        
        const string actual = "abcabcbb";
        Assert.Equal("bcb", solution.LongestPalindrome(actual));
        
        const string actual1 = "bbbbb";
        Assert.Equal(actual1, solution.LongestPalindrome(actual1));
        
        const string actual5 = "c";
        Assert.Equal(actual5, solution.LongestPalindrome(actual5));
        
        const string actual6 = "au";
        Assert.Equal("u", solution.LongestPalindrome(actual6));
        
        const string actual7 = "aab";
        Assert.Equal("aa", solution.LongestPalindrome(actual7));
        
        const string actual8 = "dvdf";
        Assert.Equal("dvd", solution.LongestPalindrome(actual8));
        
        const string actual9 = "aabaab12321";
        Assert.Equal("12321", solution.LongestPalindrome(actual9));

        const string actual10 =
            "civilwartestingwhetherthatnaptionoranynartionsoconceivedandsodedicatedcanlongendureWeareqmetonagreatbattlefiemldoftzhatwarWehavecometodedicpateaportionofthatfieldasafinalrestingplaceforthosewhoheregavetheirlivesthatthatnationmightliveItisaltogetherfangandproperthatweshoulddothisButinalargersensewecannotdedicatewecannotconsecratewecannothallowthisgroundThebravelmenlivinganddeadwhostruggledherehaveconsecrateditfaraboveourpoorponwertoaddordetractTgheworldadswfilllittlenotlenorlongrememberwhatwesayherebutitcanneverforgetwhattheydidhereItisforusthelivingrathertobededicatedheretotheulnfinishedworkwhichtheywhofoughtherehavethusfarsonoblyadvancedItisratherforustobeherededicatedtothegreattdafskremainingbeforeusthatfromthesehonoreddeadwetakeincreaseddevotiontothatcauseforwhichtheygavethelastpfullmeasureofdevotionthatweherehighlyresolvethatthesedeadshallnothavediedinvainthatthisnationunsderGodshallhaveanewbirthoffreedomandthatgovernmentofthepeoplebythepeopleforthepeopleshallnotperishfromtheearth";
        Assert.Equal("ranynar", solution.LongestPalindrome(actual10));
    }
}