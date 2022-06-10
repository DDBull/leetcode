public class Solution {
    public int LengthOfLongestSubstring(string s) {
        int ans = 0;
        if (s.Length > 0) ans = 1;
        
        for (int i = 0; i < s.Length; i++)
        {
            int cur = i - 1;
            while (cur >= 0 && !s.Substring(cur + 1, i - cur).Contains(s[cur]))
            {
                ans = Math.Max(ans, i - cur + 1);
                cur--;
            }
        }
        
        return ans;
    }
}
