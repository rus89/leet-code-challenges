using System.Collections;

namespace Problems.Challenge_04;

public class FizzBuzz
{
    public IList<string> FizzBuzzMethod(int n)
    {
        List<string> fizzList = new List<string>(new string[n]);
        for (int i = 0; i < fizzList.Count; i++)
        {
            fizzList[i] = (i + 1).ToString();
        }

        for (var i = 0; i < fizzList.Count; i++)
        {
            if (int.Parse(fizzList[i]) % 15 == 0)
            {
                fizzList[i] = "FizzBuzz";
                continue;
            }

            if (int.Parse(fizzList[i]) % 5 == 0)
            {
                fizzList[i] = "Buzz";
                continue;
            }

            if (int.Parse(fizzList[i]) % 3 == 0)
            {
                fizzList[i] = "Fizz";
            }
        }

        return fizzList;
    }

    public IList<string> FizzBuzzLeetCode(int n)
    {
        ArrayList ret = new ArrayList(n);
        for (int i = 1, fizz = 0, buzz = 0; i <= n; i++)
        {
            fizz++;
            buzz++;
            if (fizz == 3 && buzz == 5)
            {
                ret.Add("FizzBuzz");
                fizz = 0;
                buzz = 0;
            }
            else if (fizz == 3)
            {
                ret.Add("Fizz");
                fizz = 0;
            }
            else if (buzz == 5)
            {
                ret.Add("Buzz");
                buzz = 0;
            }
            else
            {
                ret.Add(i.ToString());
            }
        }

        List<string> returnList = new List<string>(ret.Capacity);
        returnList.AddRange(ret.Cast<string>());
        return returnList;
    }
}