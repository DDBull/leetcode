public class MyStack {
    
    Queue<int> stk;
    int last = 0;

    public MyStack() {
        this.stk = new();
    }
    
    public void Push(int x) {
        stk.Enqueue(x);
        last = x;
    }
    
    public int Pop() {
        Queue<int> queueCopy = new Queue<int>(stk.ToArray());
        stk.Clear();
        int x = 0;
        while (queueCopy.Count > 0)
        {
            x = queueCopy.Dequeue();
            if (queueCopy.Count > 0) 
            {
                stk.Enqueue(x);
                last = x;
            }
        }
        return x;
    }
    
    public int Top() {
        return last;
    }
    
    public bool Empty() {
        return stk.Count == 0;
    }
}

/**
 * Your MyStack object will be instantiated and called as such:
 * MyStack obj = new MyStack();
 * obj.Push(x);
 * int param_2 = obj.Pop();
 * int param_3 = obj.Top();
 * bool param_4 = obj.Empty();
 */
