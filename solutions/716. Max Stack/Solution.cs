public class MaxStack {

    private LinkedList<int> list;
    private SortedDictionary<int, Stack<LinkedListNode<int>>> map;
    
    public MaxStack() {
        this.list = new();
        this.map = new();
    }
    
    public void Push(int x) {
        var node = list.AddFirst(x);
        
        if (!map.ContainsKey(x))
        {
            map.Add(x, new Stack<LinkedListNode<int>>());
        }
        map[x].Push(node);
    }
    
    public int Pop() {
        var top = list.First;
        list.RemoveFirst();
        map[top.Value].Pop();
        
        if (map[top.Value].Count == 0)        
        {
            map.Remove(top.Value);
        }
        
        return top.Value;
    }
    
    public int Top() {
        return list.First.Value;
    }
    
    public int PeekMax() {
        return map.Last().Key;
    }
    
    public int PopMax() {
        var node = map.Last().Value.Pop();
        list.Remove(node);
        
        if (map[node.Value].Count == 0)
        {
            map.Remove(node.Value);
        }
        
        return node.Value;
    }
}

/**
 * Your MaxStack object will be instantiated and called as such:
 * MaxStack obj = new MaxStack();
 * obj.Push(x);
 * int param_2 = obj.Pop();
 * int param_3 = obj.Top();
 * int param_4 = obj.PeekMax();
 * int param_5 = obj.PopMax();
 */