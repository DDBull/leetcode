public class RandomizedSet {
    Dictionary<int, int> d;
    List<int> a;
        
    public RandomizedSet() {
        a = new();
        d = new();
    }
    
    public bool Insert(int val) {
        if (d.ContainsKey(val)) return false;
        
        a.Add(val);
        d.Add(val, a.Count - 1);
        
        return true;
    }
    
    public bool Remove(int val) {
        if (!d.ContainsKey(val)) return false;
        
        int valIndex = d[val];
        int lastIndex = a.Count - 1;
        int last = a[lastIndex];
        
        d[last] = valIndex;
        a[valIndex] = last;
        
        d.Remove(val);
        a.RemoveAt(lastIndex);
        
        return true;
    }
    
    public int GetRandom() {
        var rand = new Random();
        
        return a[rand.Next(a.Count)];
    }
}

/**
 * Your RandomizedSet object will be instantiated and called as such:
 * RandomizedSet obj = new RandomizedSet();
 * bool param_1 = obj.Insert(val);
 * bool param_2 = obj.Remove(val);
 * int param_3 = obj.GetRandom();
 */
 