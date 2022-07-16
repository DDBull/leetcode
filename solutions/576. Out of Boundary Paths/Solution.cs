// DSM. U
public class Solution 
{
    private const int MODULO = 1000000007;
    
    public int FindPaths(int m, int n, int maxMove, int startRow, int startColumn) 
    {
        int [,,] memo = new int[m, n, maxMove + 1];
        
        for (int i = 0; i < m; i++)
        {
            for (int j = 0; j < n; j++)
            {
                for (int k = 0; k <= maxMove; k++)
                {
                    memo[i, j, k] = -1;
                }
            }
        }
        
        return FindPaths(m, n, maxMove, startRow, startColumn, memo);
    }
    
    private int FindPaths(int m, int n, int remMove, int i, int j, int [,,] memo)
    {
        if (i == m || j == n || i < 0 || j < 0) return 1;
        if (remMove == 0) return 0;
        if (memo[i, j, remMove] >= 0) return memo[i, j, remMove];
        
        memo[i, j, remMove] = (
                        (FindPaths(m, n, remMove - 1, i - 1, j, memo) + FindPaths(m, n, remMove - 1, i + 1, j, memo)) % MODULO +
                        (FindPaths(m, n, remMove - 1, i, j - 1, memo) + FindPaths(m, n, remMove - 1, i, j + 1, memo)) % MODULO
                        ) % MODULO;
                         
        return memo[i, j, remMove];
    }
}
                        