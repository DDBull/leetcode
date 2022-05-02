public class Solution {
    public int[] SortArrayByParity(int[] nums) {
        int n = nums.Length;
        
        for (int i = 0; i < n - 1; i++)
        {
            if (nums[i] % 2 != 0)    
            {
                for (int j = i + 1; j < n; j++)
                {
                    if (nums[j] % 2 == 0)
                    {
                        (nums[i], nums[j]) = (nums[j], nums[i]);
                        break;
                    }
                }
            }
        }
        
        return nums;
    }
}
