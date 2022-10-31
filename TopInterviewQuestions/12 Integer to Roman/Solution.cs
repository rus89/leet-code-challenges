using System.Text;

namespace TopInterviewQuestions._12_Integer_to_Roman;

public class Solution
{
    public string IntToRoman(int num)
    {
        Dictionary<int, string> predefinedRomanNumerals = new Dictionary<int, string>
        {
            { 1, "I" }, { 4, "IV" }, { 5, "V" }, { 9, "IX" }, { 10, "X" }, { 40, "XL" }, { 50, "L" }, { 90, "XC" }, { 100, "C" }, { 400, "CD" },
            { 500, "D" }, { 900, "CM" }, { 1000, "M" }
        };
        int index = 0;
        StringBuilder stringBuilder = new StringBuilder();
        while (num > 0)
        {
            int power = (int)Math.Pow(10, index);
            index++;
            int modulo = num % (power * 10);
            if (modulo == 0) continue;
            num -= modulo;
            if (predefinedRomanNumerals.TryGetValue(modulo, out var result))
            {
                stringBuilder.Insert(0, result);
                continue;
            }

            switch (modulo)
            {
                case < 4:
                {
                    for (int i = 0; i < modulo; i += power)
                    {
                        stringBuilder.Insert(0, predefinedRomanNumerals[1]);
                    }

                    continue;
                }
                case < 9:
                {
                    stringBuilder.Insert(0, predefinedRomanNumerals[5]);
                    for (int i = 5; i < modulo; i += power)
                    {
                        stringBuilder.Insert(1, predefinedRomanNumerals[1]);
                    }

                    continue;
                }
                case < 40:
                {
                    for (int i = 0; i < modulo; i += power)
                    {
                        stringBuilder.Insert(0, predefinedRomanNumerals[10]);
                    }

                    continue;
                }
                case < 90:
                {
                    stringBuilder.Insert(0, predefinedRomanNumerals[50]);
                    for (int i = 50; i < modulo; i += power)
                    {
                        stringBuilder.Insert(1, predefinedRomanNumerals[10]);
                    }

                    continue;
                }
                case < 400:
                {
                    for (int i = 0; i < modulo; i += power)
                    {
                        stringBuilder.Insert(0, predefinedRomanNumerals[100]);
                    }

                    continue;
                }
                case < 900:
                {
                    stringBuilder.Insert(0, predefinedRomanNumerals[500]);
                    for (int i = 500; i < modulo; i += power)
                    {
                        stringBuilder.Insert(1, predefinedRomanNumerals[100]);
                    }

                    continue;
                }
                default:
                {
                    for (int i = 0; i < modulo; i += power)
                    {
                        stringBuilder.Insert(0, predefinedRomanNumerals[1000]);
                    }
                    break;
                }
            }
        }

        return stringBuilder.ToString();
    }
}