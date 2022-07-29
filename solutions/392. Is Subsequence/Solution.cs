public class Solution {
    public bool IsSubsequence(string s, string t) {
        
        int left = -1;
        
        foreach (char ch in s)
        {
            left++;
            while (left < t.Length && t[left] != ch)
            {
                left++;
            }
            
            if (left >= t.Length) return false;
        }
        
        return true;
    }
}
