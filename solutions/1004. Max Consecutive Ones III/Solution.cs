public class Solution {
    public int LongestOnes(int[] nums, int k) {
        int left = 0;
        int result = 0;
        int count = 0;
        //nums = [1,1,1,0,0,0,1,1,1,1,0], k = 2
        for (int right = 0; right < nums.Length; right++)        
        {
            if (nums[right] == 0)
            {
                count++;
            }
            
            while (count > k && left <= right)
            {
                if (nums[left] == 0)
                {
                    count--;
                }
                left++;
            }
            
            result = Math.Max(result, right - left + 1);
        }
        return result;
    }
}
