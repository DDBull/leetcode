public class Solution {
    public int MinMoves2(int[] nums) {
               
        Array.Sort(nums);
        int median = nums[nums.Length / 2];
        int sum = 0;
        
        foreach (int num in nums)
        {
            sum += Math.Abs(median - num);
        }
        
        return sum;
    }
}
