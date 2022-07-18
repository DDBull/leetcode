public class Solution {
    public int NumSubmatrixSumTarget(int[][] matrix, int target) {
        int n = matrix.Length;
        int m = matrix[0].Length;
        int [,] dp = new int[n + 1, m + 1];
        
        for (int i = 1; i <= n; i++) 
        {
            for (int j = 1; j <= m; j++)
            {
                dp[i, j] = matrix[i - 1][j - 1];
                dp[i, j] += dp[i, j - 1];
                dp[i, j] += dp[i - 1, j];
                dp[i, j] -= dp[i - 1, j - 1];
            }
        }
        
        int ans = 0;
        int cur;
        
        for (int x1 = 1; x1 <= n; x1++) 
        {
            for (int y1 = 1; y1 <= m; y1++)
            {
                for (int x2 = x1; x2 <= n; x2++)
                {
                    for (int y2 = y1; y2 <= m; y2++)
                    {
                        cur = dp[x2, y2];
                        cur -= dp[x1 - 1, y2];
                        cur -= dp[x2, y1 - 1];
                        cur += dp[x1 - 1, y1 - 1];
                                                    
                        if (cur == target) 
                        {
                            //Console.WriteLine($"{i} {j} {k} {p}");
                            ans++;
                        }
                    }
                }
            }
        }
        
        return ans;
    }
}
