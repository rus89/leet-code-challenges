namespace ChallengesForNewUsers.Challenge_01
{
    public static class RomanToIntegerSolution
    {
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