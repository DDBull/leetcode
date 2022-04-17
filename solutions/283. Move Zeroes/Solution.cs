public class Solution {
    public void MoveZeroes(int[] nums) {
        int l = 0;
        int r = 1;
        int n = nums.Length;
        
        while (r < n)
        {
            while (l < n && nums[l] != 0) l++;
            r = l + 1;
            while (r < n && nums[r] == 0) r++;
            if (r < n) 
            {
                int tmp = nums[l];
                nums[l] = nums[r];
                nums[r] = tmp;
            }
        }
    }
}
