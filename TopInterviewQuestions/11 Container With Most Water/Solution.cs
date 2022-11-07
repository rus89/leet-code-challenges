namespace TopInterviewQuestions._11_Container_With_Most_Water;

public class Solution
{
    public int MaxArea(int[] height)
    {
        int n = height.Length;
        if (n < 2) return 0;
        int numberOfZeros = 0;
        for (int i = 0; i < n; i++)
        {
            if (height[i] == 0) numberOfZeros++;
        }

        if (numberOfZeros == n || numberOfZeros == n - 1) return 0;

        int maxArea = 0;
        int currentArea;
        for (int i = 0; i < n; i++)
        {
            for (int j = n - 1; j > i; j--)
            {
                var xAxis = j - i;
                if (height[i] <= height[j])
                {
                    currentArea = height[i] * xAxis;
                    maxArea = currentArea > maxArea ? currentArea : maxArea;
                    break;
                }

                if (height[i] > height[j])
                {
                    currentArea = height[j] * xAxis;
                    maxArea = currentArea > maxArea ? currentArea : maxArea;
                }
            }
        }

        return maxArea;
    }
}