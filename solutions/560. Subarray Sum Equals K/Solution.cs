public class Solution {
    public int SubarraySum(int[] nums, int k) {
        var d = new Dictionary<int, int> { [0] = 1 };
        int sum = 0;
        int ans = 0;
        
        foreach(int num in nums)
        {
            sum += num;
            ans += d.GetValueOrDefault(sum - k);
            d[sum] = d.GetValueOrDefault(sum) + 1;
        }
        
        return ans;
    }
}
