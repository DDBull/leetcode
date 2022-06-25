public class Solution {
    public bool CheckPossibility(int[] nums) {
        int count = 0;
        int pos = -1;
        int len = nums.Length;
        
        for (int i = 0; i + 1 < len; i++) {
            if (nums[i] > nums[i + 1]) {
                count++;
                pos = i;
            }
        }
        
        if (count > 1) {
            return false;
        }
        
        if (count == 0) {
            return true;
        }
        
        return (len < 3) || (pos == 0) || (pos + 1 >= len - 1) 
            || (nums[pos - 1] <= nums[pos + 1]) || (nums[pos] <= nums[pos + 2]);
            
    }
}
