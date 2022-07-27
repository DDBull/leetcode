public class LRUCache {

    private int capacity;
    private int size;
    LinkedList<(int key, int value)> list;
    Dictionary<int, LinkedListNode<(int key, int value)>> map;
    
    public LRUCache(int capacity) {
        this.capacity = capacity;
        this.size = 0;
        list = new();
        map = new();
    }
    
    public int Get(int key) {
        if (!map.ContainsKey(key))
        {
            return -1;
        }
        
        int value = map[key].Value.value;
        list.Remove(map[key]);
        list.AddFirst((key, value));
        map[key] = list.First;
        
        return value;
    }
    
    public void Put(int key, int value) {
        if (map.ContainsKey(key))
        {
            list.Remove(map[key]);
            list.AddFirst((key, value));
            map[key] = list.First;
        }
        else
        {
            size++;
            list.AddFirst((key, value));
            var node = list.First;
            map.Add(key, node);
            
            if (size > capacity)
            {
                size--;
                node = list.Last;
                map.Remove(node.Value.key);
                list.RemoveLast();
            }
        }
    }
}

/**
 * Your LRUCache object will be instantiated and called as such:
 * LRUCache obj = new LRUCache(capacity);
 * int param_1 = obj.Get(key);
 * obj.Put(key,value);
 */