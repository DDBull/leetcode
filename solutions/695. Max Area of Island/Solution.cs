public class Solution {
    int ans = 0;
    int n;
    int m;
    int cur = 0;
    public int MaxAreaOfIsland(int[][] grid) {
        n = grid.Length;
        m = grid[0].Length;

        for (int i = 0; i < n; i++)
        {
          for (int j = 0; j < m; j++)
          {
            if (grid[i][j] == 1)
            {
              grid[i][j] = 2;
              cur = 0;
              DFS(i, j, grid);
              ans = Math.Max(ans, cur);
            }
          }
        }

        return ans;
    }

    private void DFS(int x, int y, int[][] grid)
    {
      cur++;

      if (x - 1 >= 0 && grid[x - 1][y] == 1)
      {
        grid[x - 1][y] = 2;
        DFS(x - 1, y, grid);
      }
      if (x + 1 < n && grid[x + 1][y] == 1)
      {
        grid[x + 1][y] = 2;
        DFS(x + 1, y, grid);
      }
      if (y - 1 >= 0 && grid[x][y - 1] == 1)
      {
        grid[x][y - 1] = 2;
        DFS(x, y - 1, grid);
      }
      if (y + 1 < m && grid[x][y + 1] == 1)
      {
        grid[x][y + 1] = 2;
        DFS(x, y + 1, grid);
      }
    }
}
