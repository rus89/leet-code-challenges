namespace Problems.Challenge_08;

public class Challenge08
{
    public int MaximumWealth(int[][] accounts)
    {
        List<int> customersWealth = new List<int>(accounts.Length);
        for (int i = 0; i < accounts.Length; i++)
        {
            int wealth = 0;
            for (int j = 0; j < accounts[i].Length; j++)
            {
                wealth += accounts[i][j];
            }
            customersWealth.Add(wealth);
        }
        return customersWealth.Max();
    }
}