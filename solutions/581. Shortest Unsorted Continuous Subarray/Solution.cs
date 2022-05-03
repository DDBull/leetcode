public class Solution 
{
    public int FindUnsortedSubarray(int[] nums) 
    {
        int n = nums.Length;
        int l = 0;
        int r = n - 1;
        int min = Int32.MaxValue;
        int max = Int32.MinValue;
        
        for (int i = 0; i < n; i++)
        {
            if (i > 0 && nums[i] < nums[i - 1]) min = Math.Min(min, nums[i]);
            if (i + 1 < n && nums[i] > nums[i + 1]) max = Math.Max(max, nums[i]);
        }
        
        while (l < n && min >= nums[l]) l++;
        while (r >= 0 && max <= nums[r]) r--;
        
        return r - l < 0 ? 0 : r - l + 1;
    }
}
