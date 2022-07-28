public class Solution {
    public int Trap(int[] height) {
        int ans = 0;
        int[] leftMax = new int[height.Length];
        int[] rightMax = new int[height.Length];
        
        leftMax[0] = height[0];
        rightMax[height.Length - 1] = height[height.Length - 1];
        
        for (int i = 1; i < height.Length; i++)
        {
            leftMax[i] = Math.Max(leftMax[i - 1], height[i]);
        }
        
        for (int i = height.Length - 2; i >= 0; i--)
        {
            rightMax[i] = Math.Max(rightMax[i + 1], height[i]);
        }
        
        for (int i = 1; i < height.Length - 1; i++)
        {           
            int cur = Math.Min(leftMax[i - 1], rightMax[i + 1]) - height[i];
            ans += cur > 0 ? cur : 0;
        }
        
        return ans;
    }
}
//////////////////////////


public class Solution {
    public int Trap(int[] height) {
        int left = 0;
        int right = height.Length - 1;
        int ans = 0;
        int leftMax = 0;
        int rightMax = 0;
        
        while (left < right)
        {
            if (height[left] < height[right])
            {
                if (leftMax > height[left])
                {
                    ans += leftMax - height[left];
                }
                else
                {
                    leftMax = height[left];
                }
                left++;
            }
            else
            {
                if (rightMax > height[right])
                {
                    ans += rightMax - height[right];
                }
                else
                {
                    rightMax = height[right];
                }
                right--;
            }
        }
        
        return ans;
    }
}
