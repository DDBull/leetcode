public class Solution {
    int[] a = new int[26];
    int[] b = new int[26];
    public bool IsAnagram(string s, string t) {
        foreach (char c in s) a[c - 'a']++;
        foreach (char c in t) b[c - 'a']++;
        
        for (int i = 0; i < 26; i++)
        {
            if (a[i] != b[i]) return false;
        }
        
        return true;
    }
}
