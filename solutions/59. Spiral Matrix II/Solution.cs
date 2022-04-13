public class Solution {
    public int[][] GenerateMatrix(int n) {
        int[][] a = new int[n][];
        int cur = 1;
        int i;
        int j = 0;
        
        for (i = 0; i < n; i++)
            a[i] = new int[n];

        i = 0;
        a[i][j] = cur;
        

        while (cur < n * n)
        {
          while (j + 1 < n && a[i][j + 1] == 0)
          {
            j++;
            a[i][j] = ++cur;
          }
          while (i + 1 < n && a[i + 1][j] == 0)
          {
            i++;
            a[i][j] = ++cur;
          }
          while (j - 1 >= 0 && a[i][j - 1] == 0)
          {
            j--;
            a[i][j] = ++cur;
          }
          while (i - 1 >= 0 && a[i - 1][j] == 0)
          {
            i--;
            a[i][j] = ++cur;
          }
        }

        return a;
    }
}
