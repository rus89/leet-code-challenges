namespace TopInterviewQuestions._01_Two_Sum;

public class Solution
{
    /*
     * prepostavi da postoji samo 1 resenje
     * svaki broj moze da se iskoristi samo 1x
     * napravi algoritam koji je manji od O(n2) vremenske kompleksnosti
     */
    public int[] TwoSum(int[] nums, int target)
    {
        List<int> allNums = new List<int>(nums);
        for (var i = 0; i < nums.Length; i++)
        {
            int subtract = target - nums[i];
            allNums.Remove(nums[i]);
            if (allNums.Contains(subtract))
            {
                return new[] { i, Array.IndexOf(nums, subtract, i + 1) };
            }
        }

        return Array.Empty<int>();
    }

    public int[] TwoSumLeetCode(int[] numbers, int target)
    {
        Dictionary<int, int> map = new Dictionary<int, int>();
        for (int i = 0; i < numbers.Length; map.Add(numbers[i], ++i))
            if (map.ContainsKey(target - numbers[i]))
            {
                if (map.TryGetValue(target - numbers[i], out var a))
                {
                    return new[] { a - 1, i };
                }
            }

        return new[] { 0, 0 };
    }
}