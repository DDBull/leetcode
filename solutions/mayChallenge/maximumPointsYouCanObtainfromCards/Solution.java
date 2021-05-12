class Solution {

    public int maxScore(int[] cardPoints, int k) {

        int n = cardPoints.length;
        int[] a = new int[n + 1];
        int[] b = new int[n + 1];
        int ans = Integer.MIN_VALUE;

        for (int i = 0; i < n; i++) {
            a[i + 1] = a[i] + cardPoints[i];
            b[i + 1] = b[i] + cardPoints[n - i - 1];
        }

        for (int i = 0; i <= k; i++) {
            ans = Math.max(ans, a[i] + b[k - i]);
        }

        return ans;
    }
}
