public class Solution {
    public bool IsValidSudoku(char[][] board) {
        int x;
        int[,] rows = new int[9,10];
        int[,] columns = new int[9,10];
        int[,] box = new int[9,10];
        for (int i = 0; i < 9; i++) {
            for (int j = 0; j < 9; j++) {
                if (board[i][j] == '.') {
                    continue;
                }
                x = board[i][j] - '0';
                if (x < 1 || x > 9) {
                    return false;
                } else {
                    rows[i,x]++;
                    columns[j,x]++;
                    box[i / 3 * 3 + j / 3,x]++;
                    if (rows[i,x] > 1 || columns[j,x] > 1 || box[i / 3 * 3 + j / 3,x] > 1) {
                        return false;
                    }
                }
            }
        }
        
        return true;
    }
}
