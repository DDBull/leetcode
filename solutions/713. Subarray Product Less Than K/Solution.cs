public class Solution {
    public int NumSubarrayProductLessThanK(int[] nums, int k) {
        int l = 0;
        int ans = 0;
        int cur = 1;
        
        if (k == 0) return 0;
        
        for (int r = 0; r < nums.Length; r++)
        {
            cur *= nums[r];
            
            while (cur >= k && l < nums.Length)
            {
                cur /= nums[l++];
            }
            
            if (cur < k && l <= r)
            {
                ans += r - l + 1;
            }
            else 
            {
                cur = 1;
            }
            //Console.Write($"{l} {r}\n");
        }
        
        return ans;
    }
}
