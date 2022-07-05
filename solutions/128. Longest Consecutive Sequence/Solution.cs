public class Solution {
    public int LongestConsecutive(int[] nums) {
        HashSet<int> s = new();
        int ans = 0;
        
        foreach (int num in nums) s.Add(num);
        
        foreach (int num in nums)
        {
            if (!s.Contains(num - 1))
            {
                int cur = 1;
                int n = num;
                
                while (s.Contains(++n)) ++cur;
                
                ans = Math.Max(ans, cur);
            }
        }
        
        return ans;
    }
}
