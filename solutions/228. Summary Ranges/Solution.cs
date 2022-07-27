public class Solution {
    public IList<string> SummaryRanges(int[] nums) {
        int left = 0;
        List<string> result = new();
        
        for (int right = 0; right < nums.Length; right++)
        {
            if (right + 1 < nums.Length && nums[right] + 1 != nums[right + 1])        
            {
                if (left == right)
                {
                    result.Add($"{nums[left]}");    
                }
                else
                {
                    result.Add($"{nums[left]}->{nums[right]}");
                }
                left = right + 1;
            }
            else if (right + 1 == nums.Length)
            {
                if (left == right)
                {
                    result.Add($"{nums[left]}");    
                }
                else
                {
                    result.Add($"{nums[left]}->{nums[right]}");
                }
            }
        }
        
        return result;
    }
}
