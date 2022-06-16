public class Solution {
    public string LongestPalindrome(string s) {
        string ans = string.Empty;
        ans += s[0];
        int n = s.Length;
        
        for (int i = 0; i < n; i++)
        {
            for (int j = n - 1; j > i; j--)
            {
                int l = i;
                int r = j;
                
                while (l <= r && s[l] == s[r])
                {
                    l++;
                    r--;
                }
                
                if (l > r && (j - i + 1) > ans.Length)
                {
                    ans = s.Substring(i, j - i + 1);
                }
            }
        }
        
        return ans;
    }
}
