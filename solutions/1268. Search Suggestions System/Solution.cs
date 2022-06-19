public class Solution {
    public IList<IList<string>> SuggestedProducts(string[] products, string searchWord) {
        Array.Sort(products);
        List<IList<string>> ans = new();
        
        int l = 0;
        int r = products.Length - 1;
        
        string s = string.Empty;
        
        for (int i = 0; i < searchWord.Length; i++)
        {
            s += searchWord[i];
            var cur = new List<string>();
            
            while (l < products.Length && !products[l].StartsWith(s))
            {
                l++;
            }
            
            for (int j = l; j < products.Length && j <= l + 2; j++)
            {
                if (products[j].StartsWith(s))
                {
                    cur.Add(products[j]);
                }
            }
            
            ans.Add(cur);
        }
        
        return ans;
    }
}
