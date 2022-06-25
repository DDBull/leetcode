public class Solution {
    public int[][] MatrixReshape(int[][] mat, int r, int c) {
        int n = mat.Length;
        int m = mat[0].Length;
        
        if (n * m != r * c) return mat;
        
        int[][] ans = new int[r][];
        
        for (int i = 0; i < r; i++) ans[i] = new int[c];
        
        int ii = 0;
        int jj = 0;
        
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < m; j++)
            {
                ans[ii][jj++] = mat[i][j];
                if (jj == c)
                {
                    jj = 0;
                    ii++;
                }
            }
        }
        
        return ans;
    }
}
