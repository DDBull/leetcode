public class Solution {
    int[] xx = new int[] { -1, -1, -1, 0, 0, 1, 1, 1};
    int[] yy = new int[] { -1, 0, 1, -1, 1, -1, 0, 1};
    int n;
    
    public int ShortestPathBinaryMatrix(int[][] grid) {
        
        n = grid.Length;
        
        if (grid[0][0] != 0 || grid[n - 1][n - 1] == 1) return -1;
        
        grid[0][0] = 2;
        
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                if (grid[i][j] == 0) grid[i][j] = Int32.MaxValue;
            }
        }
                
        Queue<(int, int)> q = new();
        q.Enqueue((0, 0));
        
        while (q.Count > 0)
        {
            (int x, int y) cur = q.Dequeue();
            
            for (int i = 0; i < 8; i++)
            {
                int curx = cur.x + xx[i];
                int cury = cur.y + yy[i];
                
                if (InsideBoundary(curx, cury) && grid[curx][cury] != 1 && grid[curx][cury] > grid[cur.x][cur.y] + 1)
                {
                    grid[curx][cury] = grid[cur.x][cur.y] + 1;
                    q.Enqueue((curx, cury));
                }
            }
        }
        
        return grid[n - 1][n - 1] == Int32.MaxValue ? -1 : grid[n - 1][n - 1] - 1;
    }
        
    private bool InsideBoundary(int x, int y)
    {
        return (x >= 0) && (y >= 0) && (x < n) && (y < n);
    }
}
