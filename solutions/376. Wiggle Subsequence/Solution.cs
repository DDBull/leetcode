public class Solution {
    public int WiggleMaxLength(int[] nums) {
        int n = nums.Length;
        int[] up = new int[n];
        int[] down = new int[n];
        
        up[0] = 1;
        down[0] = 1;
        
        for (int i = 1; i < n; i++)
        {
            if (nums[i] > nums[i - 1])
            {
                up[i] = down[i - 1] + 1;
                down[i] = down[i - 1];
            } 
            else if (nums[i] < nums[i - 1])
            {
                down[i] = up[i - 1] + 1;
                up[i] = up[i - 1];
            } 
            else
            {
                up[i] = up[i - 1];
                down[i] = down[i - 1];
            }
        }
        
        return Math.Max(up[n - 1], down[n - 1]);
    }
}
