class Solution {

    boolean[] prime = new boolean[5000001];

    public int countPrimes(int n) {
        int ans = n > 2 ? 1 : 0;
        boolean[] prime = new boolean[n];

        for (int i = 3; i < n; i += 2) {
            if (!prime[i]) {
                prime[i] = true;

                ans++;

                int k = 2;

                while (i * k < n) {
                    prime[i * k] = true;
                    k++;
                }
            }
        }

        return ans;
    }
}
