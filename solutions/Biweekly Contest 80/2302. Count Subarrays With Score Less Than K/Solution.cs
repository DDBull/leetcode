public class Solution {
    public long CountSubarrays(int[] nums, long k) {
        int n = nums.Length;
        
        long ans = 0;
        long sum = 0;
        int left = 0;
        
        for (int right = 0; right < n; right++)
        {
            sum += nums[right];
            
            while (sum * (right - left + 1) >= k)
            {
                sum -= nums[left];
                left++;
            }
            
            ans += right - left + 1;
        }
        
        return ans;
    }
}
