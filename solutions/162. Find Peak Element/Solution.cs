public class Solution {
    public int FindPeakElement(int[] nums) {
        int l = 0;
        int r = nums.Length - 1;
        
        while (l < r)
        {
            int m = (l + r) / 2;
            if (nums[m] > nums[m + 1]) r = m;
            else l = m + 1;
        }
        
        return l;
    }
}
