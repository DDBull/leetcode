public class MyHashSet {
    
    bool[] a;

    public MyHashSet() {
        this.a = new bool[1_000_001];
    }
    
    public void Add(int key) {
        this.a[key] = true;
    }
    
    public void Remove(int key) {
        this.a[key] = false;
    }
    
    public bool Contains(int key) {
        return a[key];
    }
}

/**
 * Your MyHashSet object will be instantiated and called as such:
 * MyHashSet obj = new MyHashSet();
 * obj.Add(key);
 * obj.Remove(key);
 * bool param_3 = obj.Contains(key);
 */
