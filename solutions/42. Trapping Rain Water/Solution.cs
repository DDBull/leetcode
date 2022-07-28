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
