import java.util.Stack;

class Solution {
    public int evalRPN(String[] tokens) {
        Stack<Integer> q = new Stack<>();

        for (String token : tokens) {
            if ("*".equals(token) || "-".equals(token) || "/".equals(token) || "+".equals(token)) {
                char operator = token.charAt(0);
                int b = q.pop();
                int a = q.pop();

                switch (operator) {
                    case '+' -> q.add(a + b);
                    case '-' -> q.add(a - b);
                    case '*' -> q.add(a * b);
                    case '/' -> q.add(a / b);
                }
            } else {
                q.add(Integer.parseInt(token));
            }
        }

        return q.pop();
    }
}
