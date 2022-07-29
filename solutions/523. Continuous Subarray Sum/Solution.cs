public class Solution {
    public bool CheckSubarraySum(int[] nums, int k) {
        Dictionary<int, int> map = new();
        map.Add(0, -1);
        int remainingSum = 0;
        
        for (int i = 0; i < nums.Length; i++)
        {
            remainingSum += nums[i];
            
            remainingSum %= k;
            
            if (map.ContainsKey(remainingSum) && i - map[remainingSum] > 1)
            {
                return true;
            } 
                        
            map.TryAdd(remainingSum, i);
        }
        
        return false;
    }
}
