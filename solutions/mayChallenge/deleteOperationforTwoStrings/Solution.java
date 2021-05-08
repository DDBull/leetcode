class Solution {

    String word1;
    String word2;

    public int minDistance(final String word1, final String word2) {
        this.word1 = word1;
        this.word2 = word2;

        int n = word1.length();
        int m = word2.length();

        int[][] dp = new int[n + 1][m + 1];

        return n + m - 2 * lcs(n, m, dp);
    }

    private int lcs(int n, int m, int[][] dp) {
        if (n * m == 0) {
            return 0;
        }

        if (dp[n][m] > 0) {
            return dp[n][m];
        }

        if (word1.charAt(n - 1) == word2.charAt(m - 1)) {
            dp[n][m] = lcs(n - 1, m - 1, dp) + 1;
        } else {
            dp[n][m] = Math.max(lcs(n - 1, m, dp), lcs(n, m - 1, dp));
        }

        return dp[n][m];
    }

    public static void main(String[] args) {
        Solution sol = new Solution();
        System.out.println(sol.minDistance("dinitrophenylhydrazine", "benzalphenylhydrazone"));
    }
}
