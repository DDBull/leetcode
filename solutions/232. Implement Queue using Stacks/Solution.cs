public class MyQueue {
    
    Stack<int> q;
    Stack<int> q2;
    private int front;

    public MyQueue() {
        q = new Stack<int>();
        q2 = new Stack<int>();
    }
    
    public void Push(int x) {
        if (q.Count == 0) front = x;
        q.Push(x);
    }
    
    public int Pop() {
        
        if (q2.Count == 0)
        {
            while (q.Count > 0)
            {
                q2.Push(q.Pop());
            }
        }
        return q2.Pop();
    }
    
    public int Peek() {
        if (q2.Count > 0) return q2.Peek();
        return front;
    }
    
    public bool Empty() {
        return q.Count == 0 && q2.Count == 0;
    }
}

/**
 * Your MyQueue object will be instantiated and called as such:
 * MyQueue obj = new MyQueue();
 * obj.Push(x);
 * int param_2 = obj.Pop();
 * int param_3 = obj.Peek();
 * bool param_4 = obj.Empty();
 */
