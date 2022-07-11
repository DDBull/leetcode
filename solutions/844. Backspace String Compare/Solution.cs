public class Solution {
    public bool BackspaceCompare(string s, string t) {
        Stack<char> q1 = new();
        Stack<char> q2 = new();
        
        foreach (char c in s)
        {
            if (c == '#')
            {
                if (q1.Count > 0) q1.Pop();
            } 
            else
            {
                q1.Push(c);
            }
        }
        
        foreach (char c in t)
        {
            if (c == '#')
            {
                if (q2.Count > 0) q2.Pop();
            } 
            else
            {
                q2.Push(c);
            }
        }
        
        if (q1.Count != q2.Count) return false;
        
        while (q1.Count > 0)
        {
            char x = q1.Pop();
            char y = q2.Pop();
            if (x != y) return false;
        }
        
        return true;
    }
}
