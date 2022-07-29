public class Solution {
    public int EvalRPN(string[] tokens) {
        Stack<int> stk = new();
        int b;
        int a;
        
        foreach(string token in tokens)
        {
            switch (token)
            {
                case "*":
                    b = stk.Pop();
                    a = stk.Pop();
                    stk.Push(a * b);
                    break;
                case "-":
                    b = stk.Pop();
                    a = stk.Pop();
                    stk.Push(a - b);
                    break;
                case "/":
                    b = stk.Pop();
                    a = stk.Pop();
                    stk.Push(a / b);
                    break;
                case "+":
                    b = stk.Pop();
                    a = stk.Pop();
                    stk.Push(a + b);
                    break;
                default:
                    stk.Push(Int32.Parse(token));
                    break;
            }
        }
        
        return stk.Pop();
    }
}
