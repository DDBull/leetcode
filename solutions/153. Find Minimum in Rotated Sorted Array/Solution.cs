public class Solution {
    public int FindMin(int[] nums) {
        int l = 0, r = nums.Length - 1;
        
        if (nums[r] >= nums[l]) return nums[0];
        
        while (l <= r)
        {
            int m = (l + r) / 2;
            
            if (nums[m] > nums[m + 1]) return nums[m + 1];
            if (nums[m - 1] > nums[m]) return nums[m];
            
            if (nums[m] > nums[0]) l = m + 1; else r = m - 1;
        }
        
        return -1;
    }
}
