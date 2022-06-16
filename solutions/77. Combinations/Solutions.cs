public class Solution {
    List<IList<int>> ans = new();
    
    public IList<IList<int>> Combine(int n, int k) {
        List<int> cur = new();
        Combinat(0, n, k, cur, 1);
        
        return ans;
    }
    
    private void Combinat(int i, int n, int k, List<int> cur, int start)
    {
        if (i == k)
        {            
            ans.Add(new List<int> (cur));
            return;
        }
        
        for (int j = start; j <= n; j++)
        {
            if (!cur.Contains(j))
            {
                cur.Add(j);
                Combinat(i + 1, n, k, cur, j + 1);
                cur.Remove(j);
            }
        }
    }
}
