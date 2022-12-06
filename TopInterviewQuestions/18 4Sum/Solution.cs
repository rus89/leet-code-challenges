namespace TopInterviewQuestions._18_4Sum;

public class Solution
{
    public IList<IList<int>> FourSum(int[] nums, int target)
    {
        // the idea is the same as in three sum challenge, to use two pointers technique
        List<IList<int>> result = new List<IList<int>>();
        
        // if the number of elements inside nums array is <= you should return an empty result
        if (nums.Length <= 3) return result;
        
        // get the length of the array and store it in the variable for the future uses
        int arrayLength = nums.Length;
        
        // you must sort array if you want to use two pointers technique
        Array.Sort(nums);
        
        // you have to use while loop so you can remove duplicates at the end of each while loop
        // since you are asked to return quadruplets, you will have 4 pointers, 3 at the beginning and 1 at the end
        // the first pointer moves to arrayLength - 3 because of the situation where all pointers are at the end of array (example below)
        // [-4, -2, -1, 0, 1, 2, 3, 4]
        //                 i, j, l, r
        int i = 0;
        while (i < arrayLength - 3)
        {
            // the second pointer can start one place after the first one because indices has to be different
            // travels to the arrayLength - 2 because of above mentioned reason
            int j = i + 1;
            while (j < arrayLength - 2)
            {
                // the third pointer can start once place after the second one because of different indices
                // the fourth pointer stars at the end of array
                var left = j + 1;
                var right = arrayLength - 1;
                
                // first we iterate over third and forth pointers 
                while (left < right)
                {
                    // it's important to convert the sum in a long because it's possible to get int numbers whose sum is greater than the int can store
                    long oneResult = (long)nums[i] + nums[j] + nums[left] + nums[right];
                    
                    // if result is less than target you have to increase left pointer and move it to the right
                    // because the array is sorted and it means that all bigger numbers are on the right
                    if (oneResult < target)
                    {
                        left++;
                    }
                    // opposite of the previous case
                    else if (oneResult > target)
                    {
                        right--;
                    }
                    // if the result is equal to the target than you are free to add it to the final list of results
                    else
                    {
                        List<int> oneSolution = new List<int> { nums[i], nums[j], nums[left], nums[right] };
                        result.Add(oneSolution);
                        
                        // here you are removing duplicates from the list
                        while (left < right && nums[left] == oneSolution[2])
                            ++left;
                        while (left < right && nums[right] == oneSolution[3])
                            --right;
                    }
                }
                
                // here you are removing duplicates from the list
                int currentJNumber = nums[j];
                while (j < nums.Length - 2 && nums[j] == currentJNumber)
                    ++j;
            }
            
            // here you are removing duplicates from the list
            int currentINumber = nums[i];
            while (i < nums.Length - 3 && nums[i] == currentINumber)
                ++i;
        }

        return result;
    }
}