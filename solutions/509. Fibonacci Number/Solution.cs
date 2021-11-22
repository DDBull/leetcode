public class Solution {
    public int Fib(int n) {
        if (n < 2) return n;

        int[] a = new int[n + 1];
        a[0] = 0;
        a[1] = 1;

        for (int i = 2; i <= n; i++)
        {
          a[i] = a[i - 1] + a[i - 2];
        }

        return a[n];
    }
}
