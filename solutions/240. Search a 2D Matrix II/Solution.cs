public class Solution {
    public bool SearchMatrix(int[][] matrix, int target) {
        int n = matrix.Length;
        int m = matrix[0].Length;
        
        for (int i = 0; i < n; i++)
        {
            if (target >= matrix[i][0] && target <= matrix[i][m - 1])
            {
                int l = 0;
                int r = m - 1;
                
                while (l <= r)
                {
                    int mid = l + (r - l) / 2;
                    
                        if (matrix[i][mid] == target)
                        {
                            return true;
                        }
                        else if (matrix[i][mid] > target)
                        {
                            r = mid - 1;
                        }
                        else
                        {
                            l = mid + 1;
                        }
                }
            }
        }
        
        return false;
    }
}
