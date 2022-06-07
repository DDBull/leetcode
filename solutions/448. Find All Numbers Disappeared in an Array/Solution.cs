public class Solution {
    public IList<int> FindDisappearedNumbers(int[] nums) {
        List<int> ans = new();
        int n = nums.Length;
        
        for (int i = 0; i < n; i++)
        {
            int cur = Math.Abs(nums[i]);
            if (nums[cur - 1] > 0) nums[cur - 1] *= -1;
        }
        
        for (int i = 0; i < n; i++)
        {
            if (nums[i] > 0) ans.Add(i + 1);
        }
        
        return ans;
    }

    public IList<int> FindDisappearedNumbers(int[] nums) {
        IEnumerable<int> dsitinctNums = nums.Select(x=>x).Distinct<int>().ToList();
        IEnumerable<int> ranges = Enumerable.Range(1, nums.Length).Select(x => x);
        return ranges.Except(dsitinctNums).ToList();
    }
}
