public class Solution {
    private int n;
    List<IList<int>> ans = new();
    List<int> l = new();
    
    public IList<IList<int>> Permute(int[] nums) {
        n = nums.Length;
        
        Compute(0, nums);
        
        return ans;
    }
    
    private void Compute(int k, int[] nums)
    {
        if (k == n)
        {
            ans.Add(new List<int>(l));
            return;
        }
        
        for (int i = 0; i < n; i++)
        {
            if (!l.Contains(nums[i]))
            {
                l.Add(nums[i]);
                Compute(k + 1, nums);
                l.Remove(nums[i]);
            }
        }
    }
}
