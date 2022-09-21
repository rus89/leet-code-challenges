namespace Problems
{
    public static class RomanToIntegerSolution
    {
        /*
            Roman numerals are represented by seven different symbols: I, V, X, L, C, D and M.
            Symbol       Value
            I             1
            V             5
            X             10
            L             50
            C             100
            D             500
            M             1000
            For example, 2 is written as II in Roman numeral, just two ones added together. 
            12 is written as XII, which is simply X + II. 
            The number 27 is written as XXVII, which is XX + V + II.

            Roman numerals are usually written largest to smallest from left to right. 
            However, the numeral for four is not IIII. 
            Instead, the number four is written as IV. Because the one is before the five we subtract it making four. 
            The same principle applies to the number nine, which is written as IX. 
            
            There are six instances where subtraction is used:
            I can be placed before V (5) and X (10) to make 4 and 9. 
            X can be placed before L (50) and C (100) to make 40 and 90. 
            C can be placed before D (500) and M (1000) to make 400 and 900.
            Given a roman numeral, convert it to an integer.

            Example 1:

            Input: s = "III"
            Output: 3
            Explanation: III = 3.
            
            Example 2:

            Input: s = "LVIII"
            Output: 58
            Explanation: L = 50, V= 5, III = 3.
           
            Example 3:

            Input: s = "MCMXCIV"
            Output: 1994
            Explanation: M = 1000, CM = 900, XC = 90 and IV = 4.

            Constraints:

            1 <= s.length <= 15
            s contains only the characters ('I', 'V', 'X', 'L', 'C', 'D', 'M').
            It is guaranteed that s is a valid roman numeral in the range [1, 3999].
         */

        private static readonly Dictionary<char, int> RomanSymbols = new()
        {
            { 'I', 1 },
            { 'V', 5 },
            { 'X', 10 },
            { 'L', 50 },
            { 'C', 100 },
            { 'D', 500 },
            { 'M', 1000 }
        };

        /// <summary>
        /// Moje resenje koje je neverovatno kompleksno i ne toliko efikasno
        /// svakako sam jako srecan i ponosan sto je mozda i najgore resenje, ali sto sam odlucio da se aktiviram u resavanju ovih problema
        /// jer me oni cine boljim programerom i daju mi izazov za moj mozak kako bi unapredio svoj nacin razmisljanja i resavanja problema
        /// sto je na kraju dana i najbitnije
        /// zelim da ostanem disciplinovan u resavanju ovih problema bez obzira koliko vremena ce biti potrebno za jedan problem
        /// </summary>
        /// <param name="romanSymbol"></param>
        /// <returns></returns>
        /// <exception cref="ArgumentOutOfRangeException"></exception>
        /// <exception cref="IndexOutOfRangeException"></exception>
        public static int RomanToInteger(string romanSymbol)
        {
            romanSymbol = romanSymbol.ToUpper();
            if (romanSymbol.Length < 1 && romanSymbol.Length > 15)
            {
                throw new ArgumentOutOfRangeException(romanSymbol, "Length of the roman string must be >= 1 and <= 15");
            }

            if (romanSymbol.Any(character => !RomanSymbols.ContainsKey(character)))
            {
                throw new IndexOutOfRangeException("There is forbidden character in the string!");
            }
            
            int result = 0;
            int number = 0;
            for (int i = 0; i < romanSymbol.Length; i++)
            {
                if (romanSymbol.Length > i + 1)
                {
                    switch (romanSymbol[i])
                    {
                        case 'I' when romanSymbol[i + 1].Equals('V'):
                            number = 4;
                            i++;
                            break;
                        case 'I' when romanSymbol[i + 1].Equals('X'):
                            number = 9;
                            i++;
                            break;
                        case 'X' when romanSymbol[i + 1].Equals('L'):
                            number = 40;
                            i++;
                            break;
                        case 'X' when romanSymbol[i + 1].Equals('C'):
                            number = 90;
                            i++;
                            break;
                        case 'C' when romanSymbol[i + 1].Equals('D'):
                            number = 400;
                            i++;
                            break;
                        case 'C' when romanSymbol[i + 1].Equals('M'):
                            number = 900;
                            i++;
                            break;
                        default:
                            number = RomanSymbols[romanSymbol[i]];
                            break;
                    }
                }
                else
                {
                    number = RomanSymbols[romanSymbol[i]];
                }

                result += number;
            }
            
            return result;
        }

        /// <summary>
        /// Resenje koje je neverovatno jednostavno i vrv dugogodisnje iskustvo u resavanju ovakvih problema
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        public static int RomanToIntegerFromInternet(string s)
        {
            //TODO: largest to smallest: add them up
            //TODO: smaller before larger: substract smaller

            int result = 0;
            for (int i = 0; i < s.Length; i++)
            {
                if (i + 1 < s.Length && RomanSymbols[s[i]] < RomanSymbols[s[i + 1]])
                {
                    result -= RomanSymbols[s[i]];
                }
                else
                {
                    result += RomanSymbols[s[i]];
                }
            }

            return result;
        }
    }
}