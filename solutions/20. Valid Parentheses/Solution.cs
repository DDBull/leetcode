class Solution {
    public bool IsValid(string s) {
        
        Stack<char> parant = new();
        
        foreach (char current in s) {            
            switch (current) {
                case '(':
                    parant.Push('(');
                    break;
                case ')':
                    if (parant.Count == 0 || parant.Peek() != '(') {
                        return false;
                    }
                    parant.Pop();
                    break;
                case '[':
                    parant.Push('[');
                    break;
                case ']':
                    if (parant.Count == 0 || parant.Peek() != '[') {
                        return false;
                    }
                    parant.Pop();
                    break;
                case '{':
                    parant.Push('{');
                    break;
                case '}':
                    if (parant.Count == 0 || parant.Peek() != '{') {
                        return false;
                    }
                    parant.Pop();
                    break;
                default:
                    return false;
            }
        }
        
        return (parant.Count == 0);
    }
}
