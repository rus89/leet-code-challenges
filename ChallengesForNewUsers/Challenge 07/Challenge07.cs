namespace Problems.Challenge_07;

public class Challenge07
{
    public int NumberOfSteps(int num)
    {
        int currentNumber = num;
        int steps = 0;
        while (currentNumber > 0)
        {
            if (currentNumber % 2 == 0)
            {
                currentNumber /= 2;
            }
            else
            {
                currentNumber--;
            }

            steps++;
        }
        return steps;
    }
}