public class Solution {
    public int FirstUniqChar(string s) {
        int j = 0;
        int n = s.Length;
        
        if (n == 1) {
            return 0;
        }
        
        for (int i = 0; i < n; i++) {
            for (j = 0; j < n; j++) {
                if (s[i] == s[j] && i != j) {
                    break;
                }
            }
            
            if (j == n) {
                return i; 
            }
        }
        
        return -1;
    }
}
