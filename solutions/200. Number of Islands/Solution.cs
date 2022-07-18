public class Solution {
    public int NumIslands(char[][] grid) {
        int n = grid.Length;
        int m = grid[0].Length;
        int ans = 0;
        Queue<(int, int)> q = new();
        
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < m; j++)
            {
                if (grid[i][j] == '1')
                {
                    ++ans;
                    
                    grid[i][j] = '0';
                    
                    q.Enqueue((i, j));
                    
                    while (q.Count > 0)
                    {
                        (int x, int y) cur = q.Dequeue();
                        
                        if (cur.x > 0 && grid[cur.x - 1][cur.y] == '1')
                        {
                            grid[cur.x - 1][cur.y] = '0';
                            q.Enqueue((cur.x - 1, cur.y));
                        }
                        if (cur.x + 1 < n && grid[cur.x + 1][cur.y] == '1')
                        {
                            grid[cur.x + 1][cur.y] = '0';
                            q.Enqueue((cur.x + 1, cur.y));
                        }
                        if (cur.y > 0 && grid[cur.x][cur.y - 1] == '1')
                        {
                            grid[cur.x][cur.y - 1] = '0';
                            q.Enqueue((cur.x, cur.y - 1));
                        }
                        if (cur.y + 1 < m && grid[cur.x][cur.y + 1] == '1') 
                        {
                            grid[cur.x][cur.y + 1] = '0';
                            q.Enqueue((cur.x, cur.y + 1));
                        }
                    }
                }
            }
        }
        
        return ans;
    }
}
