public class Solution {
    public int RemovePalindromeSub(string s) {
        int l = 0;
        int r = s.Length - 1;
        
        while (l < r)
        {
            if (s[l] != s[r]) return 2;
            l++;
            r--;
        }
        
        return 1;
    }
}
