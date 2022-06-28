public class Solution {
    public int MinDeletions(string s) {
        int[] a = new int[26];
        
        foreach (char c in s)
        {
            a[c - 'a']++;
        }
        
        Array.Sort(a);
        int ans = 0;
        
        for (int i = 24; i >= 0; i--)
        {
            if (a[i] != 0) 
            {
                while (a[i + 1] <= a[i] && a[i] > 0) 
                {
                    a[i]--;
                    ans++;
                }
            }
        }
        
        return ans;
    }
}
