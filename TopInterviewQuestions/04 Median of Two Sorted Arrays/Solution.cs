namespace TopInterviewQuestions._04_Median_of_Two_Sorted_Arrays;

public class Solution
{
    public double FindMedianSortedArrays(int[] nums1, int[] nums2)
    {
        int m = nums1.Length;
        int n = nums2.Length;
        int[] combined = new int[m + n];
        Array.Copy(nums1, 0, combined, 0, m);
        Array.Copy(nums2, 0, combined, m, n);
        Array.Sort(combined);
        var combinedLength = combined.Length;
        if (combinedLength % 2 == 0)
        {
            return (double)(combined[combinedLength / 2 - 1] + combined[combinedLength / 2]) / 2;
        }

        return combined[combinedLength / 2];
    }

    public double FindMedianSortedArraysLeetCode(int[] nums1, int[] nums2)
    {
        if (nums1.Length > nums2.Length)
        {
            FindMedianSortedArraysLeetCode(nums2, nums1);
        }

        int m = nums1.Length;
        int n = nums2.Length;
        int startPosition = 0;
        int endPosition = m;
        while (startPosition <= endPosition)
        {
            int partitionX = (startPosition + endPosition) / 2;
            int partitionY = (m + n + 1) / 2 - partitionX;
            int maxLeftX = partitionX == 0 ? int.MinValue : nums1[partitionX - 1];
            int minRightX = partitionX == m ? int.MaxValue : nums1[partitionX];

            int maxLeftY = partitionY == 0 ? int.MinValue : nums2[partitionY - 1];
            int minRightY = partitionY == n ? int.MaxValue : nums2[partitionY];

            if (maxLeftX <= minRightY && maxLeftY <= minRightX)
            {
                if ((m + n) % 2 == 0)
                {
                    return (double)(Math.Max(maxLeftX, maxLeftY) + Math.Min(minRightX, minRightY)) / 2;
                }

                return Math.Max(maxLeftX, maxLeftY);
            }

            if (maxLeftX > minRightY)
            {
                endPosition = partitionX - 1;
            }
            else
            {
                startPosition = partitionX + 1;
            }
        }

        throw new ArgumentException("One of the arguments provided to a method is not valid.");
    }
}