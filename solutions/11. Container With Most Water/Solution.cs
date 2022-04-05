public class Solution {
    public int MaxArea(int[] height) {
        int right = height.Length - 1;
        int left = 0;
        int ans = Math.Min(height[left], height[right]) * (right - left);

        while (left < right)
        {
          if (height[left] < height[right])
          {
            left++;
          } else 
          {
            right++;
          }

          ans = Math.Max(Math.Min(height[left], height[right]) * (right - left), ans);
        }

        return ans;
    }
}