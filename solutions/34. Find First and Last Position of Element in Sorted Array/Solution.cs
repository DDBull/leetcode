public class Solution {
    public int[] SearchRange(int[] nums, int target) {
        return new int[] { MinIndex(nums, target), MaxIndex(nums, target)};
    }
    
    int MinIndex(int[] nums, int target)
    {
        int res = -1, left = 0, right = nums.Length - 1;
        int mid;
        
        while (left <= right)
        {
            mid = (left + right) / 2;
            
            if (nums[mid] == target)
            {
                right = mid - 1;
                res = mid;
            }
            else if (nums[mid] > target)
            {
                right = mid - 1;
            }
            else if (nums[mid] < target)
            {
                left = mid + 1;
            }
        }
        
        return res;
    }
    
    int MaxIndex(int[] nums, int target)
    {
        int res = -1, left = 0, right = nums.Length - 1;
        int mid;
        
        while (left <= right)
        {
            mid = (left + right) / 2;
            
            if (nums[mid] == target)
            {
                left = mid + 1;
                res = mid;
            }
            else if (nums[mid] > target)
            {
                right = mid - 1;
            }
            else if (nums[mid] < target)
            {
                left = mid + 1;
            }
        }
        
        return res;
    }
}
