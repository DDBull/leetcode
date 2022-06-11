public class Solution {
    
    int ans = Int32.MaxValue;
    
    public int MinOperations(int[] nums, int x) {

        int n = nums.Length;
        
        if (nums.Sum() < x) 
        {
            return -1;
        }
        
        if (nums.Sum() == x)
        {
            return n;
        }
        
        int[] sum = new int[n + 1];
        sum[0] = 0;
        
        for (int i = 0; i < n; i++)
        {
            sum[i + 1] = sum[i] + nums[i];
        }
        
        for (int i = 0; i < n; i++)
        {
            int l = i + 1;
            int r = n;
            
            while (l <= r)
            {
                int m = (l + r) / 2;
                int cur = sum[n] - sum[m] + sum[i];
                if (cur == x)
                {
                    ans = Math.Min(n - m + i, ans);
                    l = m + 1;
                } else if (cur > x)
                {
                    l = m + 1;
                } else
                {
                    r = m - 1;
                }
            }
        }
        
        if (ans != Int32.MaxValue) return ans;
        
        return -1;
    }
}
