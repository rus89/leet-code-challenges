namespace TopInterviewQuestions._16_3Sum_Closest;

public class Solution
{
    public int ThreeSumClosest(int[] nums, int target)
    {
        if (nums.Length <= 2) return target;
        HashSet<int> results = new HashSet<int>();
        Array.Sort(nums);
        int start = 0;
        // [0,1,1,1]
        //  x,s,l,r
        while (start < nums.Length - 2)
        {
            var difference = (nums[start] - target) * -1;
            var left = start + 1;
            var right = nums.Length - 1;
            while (left < right)
            {
                if (nums[left] + nums[right] < difference)
                {
                    results.Add(nums[start] + nums[left++] + nums[right]);
                }
                else if (nums[left] + nums[right] > difference)
                {
                    results.Add(nums[start] + nums[left] + nums[right--]);
                }
                else
                {
                    return target;
                }
            }

            start++;
        }

        int closestNumber = int.MaxValue;
        int minDifference = int.MaxValue;
        foreach (var result in results)
        {
            var difference = Math.Abs(result - target);
            if (difference < minDifference)
            {
                minDifference = difference;
                closestNumber = result;
            }
        }

        return closestNumber;
    }
}