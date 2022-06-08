public class Solution {
    public IList<IList<string>> GroupAnagrams(string[] strs) {
        Dictionary<string, List<string>> hm = new();
        List<IList<string>> ans = new List<IList<string>>();
        
        foreach (string s in strs)
        {
            string key = String.Concat(s.OrderBy(c => c));
            if (hm.ContainsKey(key))
            {
                hm[key].Add(s);
                
            } else 
            {
                List<string> ls = new();
                ls.Add(s);
                hm.Add(key, ls);
            }
        }
        
        foreach (KeyValuePair<string, List<string>> kvp in hm)
        {
            ans.Add(kvp.Value);
        }
        
        return ans;
    }
}
