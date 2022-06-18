public class Solution {
    public int Rob(int[] nums) {
        int n = nums.Length;
        int ans = nums[0];
        int[] dp = new int[n];
        dp[0] = nums[0];
        
        for (int i = 1; i < n; i++)
        {
            dp[i] = nums[i];
            for (int j = i - 2; j >= 0; j--)
            {
                dp[i] = Math.Max(dp[i], nums[i] + dp[j]);
            }
            ans = Math.Max(ans, dp[i]);
        }
        
        return ans;
    }
}
