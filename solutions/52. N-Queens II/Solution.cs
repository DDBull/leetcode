public class Solution {
    HashSet<int> column = new();
    HashSet<int> positiveDiagonal = new();
    HashSet<int> negativeDiagonal = new();
    int counter = 0;
    
    public int TotalNQueens(int n) {
        Solve(0, n);
        return counter;
    }
    
    private void Solve(int row, int n)
    {
        if (row == n)
        {
            counter++;
            return;
        }
        
        for (int col = 0; col < n; col++)
        {
            if (column.Contains(col) || positiveDiagonal.Contains(row + col) || negativeDiagonal.Contains(row - col))
            {
                continue;
            }
            
            column.Add(col);
            positiveDiagonal.Add(row + col);
            negativeDiagonal.Add(row - col);
            
            Solve(row + 1, n);
            
            column.Remove(col);
            positiveDiagonal.Remove(row + col);
            negativeDiagonal.Remove(row - col);
        }
    }
}
