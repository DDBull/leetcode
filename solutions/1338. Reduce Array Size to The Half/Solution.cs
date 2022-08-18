public class Solution 
{
    public int MinSetSize(int[] arr) 
    {
        var map = new Dictionary<int, int>();
        foreach (int x in arr)
        {
            map.TryAdd(x, 0);
            map[x]++;
        }
        
        int count = 0, score = 0, n = arr.Length / 2;
        var a = map.OrderByDescending(x => x.Value).ToArray();
        
        for (int i = 0; i < a.Length; ++i)
        {
            score += a[i].Value;
            ++count;
            
            if (score >= n) break;
        }
        
        return count;
    }
}
