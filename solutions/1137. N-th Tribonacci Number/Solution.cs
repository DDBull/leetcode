public class Solution {
    public int Tribonacci(int n) {
      int[] a = new int[n + 1];

      if (n < 2) return n;

      a[0] = 0;
      a[1] = 1;
      a[2] = 1;

      for (int i = 3; i <= n; i++)
      {
        a[i] = a[i - 3] + a[i - 2] + a[i - 1];
      }

      return a[n];
    }
}
