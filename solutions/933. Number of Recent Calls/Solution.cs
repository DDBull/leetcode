public class RecentCounter {
    Queue<int> calls;
    
    public RecentCounter() {
        this.calls = new();
    }
    
    public int Ping(int t) {
        calls.Enqueue(t);
        
        while (calls.Peek() < t - 3000)
        {
            calls.Dequeue();
        }
        
        return calls.Count;
    }
}

/**
 * Your RecentCounter object will be instantiated and called as such:
 * RecentCounter obj = new RecentCounter();
 * int param_1 = obj.Ping(t);
 */