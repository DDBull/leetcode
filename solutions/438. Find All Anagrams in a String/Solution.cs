public class Solution {
    public IList<int> FindAnagrams(string s, string p) {
        int[] a = new int[26];
        int[] b = new int[26];
        int m = p.Length;
        List<int> ans = new();
        
        foreach (char c in p) b[c - 'a']++;
        
        for (int i = 0; i < s.Length; i++)
        {
            int j = 0;
            
            a[s[i] - 'a']++;
                
            if (i - m >= 0)
            {
                a[s[i - m] - 'a']--;
            }
            
            for (j = 0; j < 26; j++)
            {
                if (a[j] != b[j]) break;
            }
            
            if (j == 26)
            {
                ans.Add(i - m + 1);
            }
        }
        
        return ans;
    }
}
