public class Solution 
{
    public string RemoveDuplicates(string s, int k) 
    {
        Stack<(char c, int count)> stack = new(new (char, int)[] { ('!', 0) });
        foreach (char c in s) 
        {
            var top = stack.Pop();
            if (top.c == c)
                stack.Push((c, top.count + 1));
            else 
            {
                stack.Push(top);
                stack.Push((c, 1));
            }
            if (stack.Peek().count == k) stack.Pop();
        }
        return String.Concat(stack.SelectMany(p => Enumerable.Repeat(p.c, p.count)).Reverse());
    }
}
