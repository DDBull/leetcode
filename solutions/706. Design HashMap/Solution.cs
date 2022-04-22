public class MyHashMap {
    
    int[] a;

    public MyHashMap() {
        this.a = new int[1_000_001];
        for (int i = 0; i < 1_000_001; i++) a[i] = -1;
    }
    
    public void Put(int key, int value) {
        a[key] = value;
    }
    
    public int Get(int key) {
        return a[key];
    }
    
    public void Remove(int key) {
        a[key] = -1;
    }
}

/**
 * Your MyHashMap object will be instantiated and called as such:
 * MyHashMap obj = new MyHashMap();
 * obj.Put(key,value);
 * int param_2 = obj.Get(key);
 * obj.Remove(key);
 */
 