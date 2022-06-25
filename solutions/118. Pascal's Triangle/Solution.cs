public class Solution {
    public IList<IList<int>> Generate(int n) {
        List<IList<int>> ans = new();
        
        for (int i = 0; i < n; i++)
        {
            ans.Add(new List<int> ());
            ans[i].Add(1);
            for (int j = 1; j <= i; j++)
            {
                if (j == i)
                {
                    ans[i].Add(1);
                } 
                else 
                {
                    ans[i].Add(ans[i - 1][j - 1] + ans[i - 1][j]);    
                }
            }
        }
        
        return ans;
    }
}
