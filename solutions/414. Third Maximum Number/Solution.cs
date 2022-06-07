public class Solution {
    public int ThirdMax(int[] nums) {
        SortedSet<int> ss = new();
        
        for (int i = 0; i < nums.Length; i++)
        {
            ss.Add(nums[i]);
        }
        
        int ans = ss.Max;
        
        if (ss.Count > 2)
        {
           ss.Remove(ans);
           ans = ss.Max;
           ss.Remove(ans);
           ans = ss.Max;
        }
        
        return ans;
    }
}
