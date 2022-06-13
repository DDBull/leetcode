public class Solution {
    public int MinimumTotal(IList<IList<int>> triangle) {
        int depth = triangle.Count;
        
        List<List<int>> cur = new List<List<int>> ();
        int ans = Int32.MaxValue;
        
        for (int i = 0; i < depth; i++)
        {
            List<int> l = new ();
            
            for (int j = 0; j < triangle[i].Count; j++) l.Add(Int32.MaxValue);
            cur.Add(l);
        }
        
        cur[0][0] = triangle[0][0];
        
        for (int i = 0; i + 1 < depth; i++)
        {
            for (int j = 0; j < cur[i].Count; j++)
            {
                cur[i + 1][j] = Math.Min(cur[i + 1][j], cur[i][j] + triangle[i + 1][j]);
                cur[i + 1][j + 1] = Math.Min(cur[i + 1][j + 1], cur[i][j] + triangle[i + 1][j + 1]);
            }
        }
        
        for (int j = 0; j < cur[depth - 1].Count; j++)
        {
            ans = Math.Min(ans, cur[depth - 1][j]);
        }
        
        return ans;
    }
}
