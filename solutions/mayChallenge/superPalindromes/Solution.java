class Solution {

    public int superpalindromesInRange(String left, String right) {

        int ans = 9 >= Long.parseLong(left) && 9 <= Long.parseLong(right) ? 1 : 0; // Count number 3

        for (int i = 1; i <= (int) Math.pow(3, 9); i++) {
            String num = Integer.toString(i, 3);

            if (isPalindrome(num)) {
                long square = Long.parseLong(num) * Long.parseLong(num);

                if (Long.parseLong(right) < square) {
                    return ans;
                }
                if (Long.parseLong(left) <= square && isPalindrome(Long.toString(square))) {
                    ans++;
                }
            }
        }

        return ans;
    }

    private boolean isPalindrome(final String num) {
        int len = num.length();
        for (int i = 0; i < len / 2; i++) {
            if (num.charAt(i) != num.charAt(len - 1 - i)) {
                return false;
            }
        }

        return true;
    }
}
