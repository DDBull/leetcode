public class Solution {
    public int MaxScore(int[] cardPoints, int k) {
        int n = cardPoints.Length;
        int[] a = new int[n + 1];
        int[] b = new int[n + 1];
        int ans = Int32.MinValue;

        for (int i = 0; i < n; i++) {
            a[i + 1] = a[i] + cardPoints[i];
            b[i + 1] = b[i] + cardPoints[n - i - 1];
        }

        for (int i = 0; i <= k; i++) {
            ans = Math.Max(ans, a[i] + b[k - i]);
        }

        return ans;
    }
}
