public class Solution {
    public bool SearchMatrix(int[][] matrix, int target) {
        int i = 0;
        int n = matrix.Length;
        
        while (i < n)
        {
            if (i + 1 < n && target >= matrix[i + 1][0])
            {
                i++;
            }
            else
            {
                foreach (int k in matrix[i])
                {
                    if (k == target) return true;
                }
                return false;
            }
        }
        
        return false;
    }
}
