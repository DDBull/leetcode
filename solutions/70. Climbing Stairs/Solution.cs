public class Solution {
    public int ClimbStairs(int n) {
        int[] a = new int[n + 1];
        a[0] = 1;

        for (int i = 1; i <= n; i++)
        {
            a[i] = i - 2 >= 0 ? a[i - 2] + a[i - 1] : a[i - 1];
        }

        return a[n];
    }
}
