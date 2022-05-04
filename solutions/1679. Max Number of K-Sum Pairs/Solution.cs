public class Solution {
    public int MaxOperations(int[] nums, int k) {
        int l = 0;
        int r = nums.Length - 1;
        Array.Sort(nums);
        int ans = 0;
        
        while (l < r)
        {
            int sum = nums[l] + nums[r];
            if (sum == k)
            {
                ans++;
                l++;
                r--;
            } 
            else if (sum > k)
            {
                r--;
            }
            else
            {
                l++;
            }
        }
        
        return ans;
    }
}
