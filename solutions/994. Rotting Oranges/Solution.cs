public class Solution {
    public int OrangesRotting(int[][] grid) {
        Queue< Tuple <int, int> > q = new();
        int n = grid.Length;
        int m = grid[0].Length;
        
        int[] dx = new int[] { -1, 0, 0, 1 };
        int[] dy = new int[] { 0, -1, 1, 0 };
        
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < m; j++)
            {
                if (grid[i][j] == 2)
                {
                    q.Enqueue(new Tuple <int, int> (i, j));
                }
            }
        }
        
        int ans = 0;
        
        while (q.Count > 0)
        {
            Tuple <int, int> cur = q.Dequeue();
            int x = cur.Item1;
            int y = cur.Item2;
            ans = Math.Max(ans, grid[x][y]);
            
            for (int i = 0; i < 4; i++)
            {
                if (x + dx[i] >= 0 && x + dx[i] < n && y + dy[i] >= 0 && y + dy[i] < m && grid[x + dx[i]][y + dy[i]] == 1)
                {
                    grid[x + dx[i]][y + dy[i]] = grid[x][y] + 1;
                    q.Enqueue( new Tuple<int, int> (x + dx[i], y + dy[i]));
                }
            }
        }
        
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < m; j++)
            {
                if (grid[i][j] == 1)
                {
                    return -1;
                }
            }
        }
        
        if (ans == 0) return ans;
        return ans - 2;
    }
}
