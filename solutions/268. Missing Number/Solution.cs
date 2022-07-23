public class Solution {
    public int MissingNumber(int[] nums) {
        int n = nums.Length;
        int cur = 0;
        
        for (int i = 0; i < n; i++)
        {
            cur = cur ^ nums[i];
            cur = cur ^ (i + 1);
        }
        
        return cur;
    }
}
