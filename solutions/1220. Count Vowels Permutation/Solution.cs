public class Solution {
    public int CountVowelPermutation(int n) {
        var dp = new int[n, 5];
        const int MOD = 1000000007;
        
        for (int i = 0; i < 5; i++) dp[0, i] = 1;
        
        for (int i = 1; i < n; i++)
        {
            //a
            dp[i, 0] = (dp[i, 0] + dp[i - 1, 1]) % MOD;
            dp[i, 0] = (dp[i, 0] + dp[i - 1, 2]) % MOD;
            dp[i, 0] = (dp[i, 0] + dp[i - 1, 4]) % MOD;
            //e
            dp[i, 1] = (dp[i, 1] + dp[i - 1, 0]) % MOD;
            dp[i, 1] = (dp[i, 1] + dp[i - 1, 2]) % MOD;
            //i
            dp[i, 2] = (dp[i, 2] + dp[i - 1, 1]) % MOD;
            dp[i, 2] = (dp[i, 2] + dp[i - 1, 3]) % MOD;
            //o
            dp[i, 3] = (dp[i, 3] + dp[i - 1, 2]) % MOD;
            //u
            dp[i, 4] = (dp[i, 4] + dp[i - 1, 2]) % MOD;
            dp[i, 4] = (dp[i, 4] + dp[i - 1, 3]) % MOD;
        }
        
        int ans = 0;
        
        for (int i = 0; i < 5; i++) ans = (ans + dp[n - 1, i]) % MOD;
        
        return ans;
    }
}
