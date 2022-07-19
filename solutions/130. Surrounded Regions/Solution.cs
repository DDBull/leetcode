public class Solution {
    public void Solve(char[][] board) {
        int n = board.Length;
        int m = board[0].Length;
        
        int[] corX = new int[] {-1, 0, 0, 1};
        int[] corY = new int[] {0, -1, 1, 0};
        
        bool[,] state = new bool[n, m];
        
        Queue<(int, int)> q = new();
        
        for (int i = 0; i < n; i++)
        {
            if (board[i][0] == 'O')
            {
                state[i, 0] = true;
                q.Enqueue((i, 0));
            }
            if (m - 1 > 0 && board[i][m - 1] == 'O')
            {
                state[i, m - 1] = true;
                q.Enqueue((i, m - 1));
            }
        }
        
        for (int j = 0; j < m; j++)
        {
            if (board[0][j] == 'O' && !state[0, j])
            {
                state[0, j] = true;
                q.Enqueue((0, j));
            }
            if (board[n - 1][j] == 'O' && !state[n - 1, j])
            {
                state[n - 1, j] = true;
                q.Enqueue((n - 1, j));
            }
        }
        
        while (q.Count > 0)
        {
            (int x, int y) cur = q.Dequeue();
            
            for (int i = 0; i < 4; i++)
            {
                int x = cur.x + corX[i];
                int y = cur.y + corY[i];
                
                if (x >= 0 && x < n && y >= 0 && y < m && !state[x, y] && board[x][y] == 'O')
                {
                    state[x, y] = true;
                    q.Enqueue((x, y));
                }
            }
        }
        
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < m; j++)
            {
                if (board[i][j] == 'O' && !state[i, j])
                {
                    board[i][j] = 'X';
                }
            }
        }
    }
}
