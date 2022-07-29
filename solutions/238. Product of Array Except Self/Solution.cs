public class Solution {
    public int[] ProductExceptSelf(int[] nums) {
        int zeroesCount = 0;
        int productWithoutZero = 1;
        int product = 1;
        int[] result = new int[nums.Length];
        
        
        foreach (int num in nums)
        {
            if (num == 0)
            {
                zeroesCount++;
                
                if (zeroesCount > 1)
                {
                    for (int i = 0; i < nums.Length; i++)
                    {
                        result[i] = 0;
                    }
                    return result;
                }
            } 
            else
            {
                
                productWithoutZero *= num;
            }
            product *= num;
        }
        
        for (int i = 0; i < nums.Length; i++)
        {
            if (nums[i] == 0)
            {
                result[i] = productWithoutZero;
            }
            else
            {
                result[i] = product / nums[i];
            }
        }
        
        return result;
    }
}
