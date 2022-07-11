public class Solution {
    public int Search(int[] nums, int target) {
        int pivot = FindPivot(nums, 0, nums.Length - 1);
        int ans = -1;
        
        if (pivot != -1)
        {
            ans = Array.BinarySearch(nums, 0, pivot, target);
            if (ans >= 0) return ans;
            
            ans = Array.BinarySearch(nums, pivot, nums.Length - pivot , target);
            if (ans >= 0) return ans;
            ans = -1;
        } else
        {
            ans = Array.BinarySearch(nums, target);
            if (ans < 0) ans = -1;
        }
        
        return ans;
    }
    
    private int FindPivot(int[] nums, int ll, int rr)
    {
        int l = ll;
        int r = rr;
        
        while (l < r)
        {
            int m = (l + r) / 2;
            
            if (nums[m] > nums[m + 1]) return m + 1;
            else 
            {
                int pivot = FindPivot(nums, m + 1, r);
                if (pivot != -1) return pivot;
                r = m;
            }
        }
        
        if (l + 1 < nums.Length && nums[l] > nums[l + 1]) return l + 1;
        
        return -1;
    }
}
