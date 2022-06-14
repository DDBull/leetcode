public class Solution {
    public int MinDistance(string word1, string word2) {
        int n = word1.Length;
        int m = word2.Length;
        
        int[, ] dp = new int[n + 1, m + 1];
        
        return n + m - 2 * lcs(n, m, dp, word1, word2);
    }
    
    private int lcs(int n, int m, int[,] dp, string word1, string word2)
    {
        if (n * m == 0) return 0;
        
        if (dp[n, m] > 0) return dp[n, m];
        
        if (word1[n - 1] == word2[m - 1])
        {
            dp[n, m] = 1 + lcs(n - 1, m - 1, dp, word1, word2);
        } else
        {
            dp[n, m] = Math.Max(lcs(n - 1, m, dp, word1, word2), lcs(n, m - 1, dp, word1, word2));
        }
        
        return dp[n, m];
    }
}
