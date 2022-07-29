public class Solution {
    public int RemoveDuplicates(int[] nums) 
    {    
        int left = 0;
        
        for (int right = 0; right < nums.Length; right++)
        {
            if (right + 1 == nums.Length || nums[right] != nums[right + 1])
            {
                (nums[left], nums[right]) = (nums[right], nums[left]);
                left++;
            }
        }
        
        return left;
    }
}
