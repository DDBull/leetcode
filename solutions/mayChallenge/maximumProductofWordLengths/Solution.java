class Solution {
    public int maxProduct(String[] words) {
        int len = words.length;
        boolean[][] letters = new boolean[len][26];

        for (int i = 0; i < len; i++) {
            for (int j = 0; j < words[i].length(); j++) {
                int letter = words[i].charAt(j) - 'a';
                letters[i][letter] = true;
            }
        }

        int ans = 0;

        for (int i = 0; i < len - 1; i++) {
            for (int j = i + 1; j < len; j++) {
                int k;
                for (k = 0; k < 26; k++) {
                    if (letters[i][k] && letters[j][k]) {
                        break;
                    }
                }
                if (k == 26) ans = Math.max(ans, words[i].length() * words[j].length());
            }
        }

        return ans;
    }
}
