public class Solution {
    public int MinSubArrayLen(int target, int[] nums) {
        int len = Int32.MaxValue;
        
        int l = 0;
        int sum = 0;
        
        for (int r = 0; r < nums.Length; r++)
        {
            sum += nums[r];
            
            while (sum - nums[l] >= target && l < nums.Length)
            {
                sum -= nums[l++];
            }
            
            if (sum >= target) len = Math.Min(len, r - l + 1);
        }
        
        return len == Int32.MaxValue ? 0 : len;
    }
}
