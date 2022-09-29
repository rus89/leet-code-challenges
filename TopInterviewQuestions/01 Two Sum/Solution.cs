namespace Problems.Top_Interview_Questions._01_Two_Sum;

public class Solution
{
    /*
     * prepostavi da postoji samo 1 resenje
     * svaki broj moze da se iskoristi samo 1x
     * napravi algoritam koji je manji od O(n2) vremenske kompleksnosti
     */
    public int[] TwoSum(int[] nums, int target)
    {
        for (int i = 0; i < nums.Length; i++)
        {
            int subtract = target - nums[i];
            int found = nums.Skip(i).First(e => e == subtract);
            if (found > 0)
            {
                return new[] {i, Array.IndexOf(nums, found)};
            }
        }
        return new int[] { };
    }
}