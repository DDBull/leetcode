public class HitCounter {

    Dictionary<int, int> map;
    private const int LIMIT = 300;
    
    public HitCounter() 
    {
        map = new();
    }
    
    public void Hit(int timestamp) 
    {
        if (!map.ContainsKey(timestamp))
        {
            map.Add(timestamp, 1);
        }
        else
        {
            map[timestamp]++;
        }
        ClearMap(timestamp);
    }
    
    public int GetHits(int timestamp) 
    {
        int result = 0;    
        ClearMap(timestamp);
        
        foreach(var entity in map)
        {
            result += entity.Value;    
        }
        
        return result;
    }
    
    private void ClearMap(int timestamp)
    {
        foreach(var entity in map)
        {
            if (entity.Key <= timestamp - LIMIT)
            {
                map.Remove(entity.Key);
            }
        }
    }
}

/**
 * Your HitCounter object will be instantiated and called as such:
 * HitCounter obj = new HitCounter();
 * obj.Hit(timestamp);
 * int param_2 = obj.GetHits(timestamp);
 */