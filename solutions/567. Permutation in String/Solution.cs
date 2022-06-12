public class Solution {
    public bool CheckInclusion(string s1, string s2) {
        int[] letters = new int[26];
        
        if (s1.Length > s2.Length) return false;
        
        foreach (char letter in s1)
        {
            letters[letter - 'a']++;
        }
        
        int[] cur = new int[26];
        
        for (int i = 0; i < s1.Length; i++) cur[s2[i] - 'a']++;
        
        if (TheSame(letters, cur)) return true;
        int l = 0;
        
        for (int i = s1.Length; i < s2.Length; i++)
        {
            cur[s2[l++] - 'a']--;
            cur[s2[i] - 'a']++;
            if (TheSame(letters, cur)) return true;
        }
        
        return false;
    }
    
    private bool TheSame(int[] a, int[] b)
    {
        for (int i = 0; i < 26; i++)
        {
            if (a[i] != b[i]) return false;
        }
        
        return true;
    }
}
