public class Solution {
    public int LongestSubarray(int[] nums) {
        int[] dp = new int[nums.Length];
        int result = 0;
        
        for (int i = 0; i < nums.Length; i++)
        {
            if (nums[i] == 1 && dp[i] == 0)
            {
                int rightIndex = i;
                
                while (rightIndex + 1 < nums.Length && nums[rightIndex + 1] == 1)
                {
                    rightIndex++;
                }
                
                int len = rightIndex - i + 1;
                
                for (int j = i; j <= rightIndex; j++)
                {
                    dp[j] = len;
                }
                
                result = Math.Max(result, len);
            }
        }
        
        result--; 
        
        for (int i = 0; i < nums.Length; i++)
        {
            if (nums[i] == 0)
            {
                int cur = 0;
                
                if (i - 1 >= 0)
                {
                    cur += dp[i - 1];
                }
                if (i + 1 < nums.Length)
                {
                    cur += dp[i + 1];
                }
                
                result = Math.Max(cur, result);
            }
        }
        
        return result;
    }
}
