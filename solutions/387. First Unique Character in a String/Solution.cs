public class Solution {
    public int FirstUniqChar(string s) {
        
        int n = s.Length;
        
        int[] letterIdx = new int[26];
        
        for (int i = 0; i < n; i++)
        {
            if (letterIdx[s[i] - 'a'] == 0)
            {
                letterIdx[s[i] - 'a'] = i + 1;
            }
            else
            {
                //duplicate
                letterIdx[s[i] - 'a'] = -1;
            }
        }
        int ans = Int32.MaxValue;
        for (int i = 0; i < 26; i++)
        {
            if (letterIdx[i] > 0)
            {
                ans = Math.Min(ans, letterIdx[i] - 1);
            }
        }
        
        return ans == Int32.MaxValue ? -1 : ans;
    }
}
