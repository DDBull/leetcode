/*
valid numbers: ["2", "0089", "-0.1", "+3.14", "4.", "-.9", "2e10", "-90E3", "3e+7", "+6e-1", "53.5e93", "-123.456e789"]
not valid numbers: ["abc", "1a", "1e", "e3", "99e2.5", "--6", "-+3", "95a54e53"].
*/

class Solution {
    public boolean isNumber(String s) {
        boolean digit = false;
        boolean dot = false;
        boolean sign = false;
        boolean e = false;

        for (int i = 0; i < s.length(); i++) {

            switch (s.charAt(i)) {
                case '+', '-' -> {
                    if (sign) {
                        return false;
                    }
                    if (e && (i > 0 && s.charAt(i - 1) != 'e')) {
                        return false;
                    }
                    if (i > 0 && !e) {
                        return false;
                    }
                    sign = true;
                }
                case 'e', 'E' -> {
                    if (e || !digit) {
                        return false;
                    }
                    e = true;
                    digit = false;
                    sign = false;
                }
                case '.' -> {
                    if (dot || e) {
                        return false;
                    }
                    dot = true;
                }
                case '0','1','2','3','4','5','6','7','8','9' -> {
                    digit = true;
                }
                default -> {
                    return false;
                }
            }
        }

        return digit;
    }
}
