namespace Problems.Challenge_06;

public class Challenge06
{
    public int[] KWeakestRows(int[][] mat, int k)
    {
        Dictionary<int, int> soldiersWithIndexes = new Dictionary<int, int>();
        for (int i = 0; i < mat.Length; i++)
        {
            for (int j = 0; j < mat[i].Length; j++)
            {
                soldiersWithIndexes[i] = mat[i].Count(soldier => soldier == 1);
            }
        }

        soldiersWithIndexes = new Dictionary<int, int>(soldiersWithIndexes.OrderBy(pair => pair.Value));
        var soldiersInRows = soldiersWithIndexes.Keys.Take(k).ToArray();
        return soldiersInRows;
    }
}