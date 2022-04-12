public class Solution {

    private bool WithinBorders(int q, int w)
    {
      return (q >= 0) && (q < w);
    }
    
    public void GameOfLife(int[][] board) {
      int n = board.Length;
      int m = board[0].Length;
      int[] x = { -1, -1, -1, 0, 0, 1, 1, 1 };
      int[] y = { -1, 0, 1, -1, 1, -1, 0, 1 };
      int[,] ans = new int[n, m];

      for (int i = 0; i < n; i++)
      {
        for (int j = 0; j < m; j++)
        {
          int one = 0;
          for (int k = 0; k < 8; k++)
          {
            int q = i + x[k];
            int w = j + y[k];
            if (WithinBorders(q, n) && WithinBorders(w, m))
            {
              if (board[q][w] == 1) one++;
            }
          }
          
          if (board[i][j] == 1 && one < 2) ans[i, j] = 0; 
          else if (board[i][j] == 1 && one < 4) ans[i, j] = 1;
          else if (board[i][j] == 1) ans[i, j] = 0;
          else if (board[i][j] == 0 && one == 3) ans[i, j] = 1;
          else ans[i, j] = board[i][j];
        }
      }

      for (int i = 0; i < n; i++)
      {
        for (int j = 0; j < m; j++)
        {
          board[i][j] = ans[i, j];
        }
      }
    }
}
