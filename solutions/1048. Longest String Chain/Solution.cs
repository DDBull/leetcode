public class Solution {
    public int LongestStrChain(string[] words) {
        sortByLength myComparer = new sortByLength();
        
        int ans = 0;
        Array.Sort(words, myComparer);
        
        Dictionary <string, int> dt = new();
        
        for (int i = 0; i < words.Length; i++)
        {
            int cur = 0;
            string s = string.Empty;
            
            for (int j = 0; j < words[i].Length; j++)
            {
                if (j > 0) s = words[i].Substring(0, j); 
                if (j + 1 < words[i].Length) s += words[i].Substring(j + 1);
                
                if (dt.ContainsKey(s))
                {
                    cur = Math.Max(cur, dt[s]);
                }
            }
            
            cur++;
            
            if (dt.ContainsKey(words[i]))
            {
                dt[words[i]] = Math.Max(dt[words[i]], cur);
            } else
            {
                dt.Add(words[i], cur);
            }
            
            ans = Math.Max(ans, cur);
        }
        
        return ans;
    }
    
    private class sortByLength : IComparer  {
        int IComparer.Compare( Object x, Object y )  {
            string s1 = (string) x;
            string s2 = (string) y;
            
            if (s1.Length > s2.Length)
               return 1;

            if (s1.Length < s2.Length)
               return -1;

            else
               return 0;
        }
    }

    public int LongestStrChain(string[] words)
    {
        HashSet<string> wordsAsHashSet = words.ToHashSet();
        Dictionary<string, int> dp = new();
        return words.Max(GetLongestChain);

        int GetLongestChain(string word)
            => 1 + Enumerable.Range(0, word.Length)
                    .Select(index => word[..index] + word[(index + 1)..])
                    .Where(predecessor => wordsAsHashSet.Contains(predecessor))
                    .Select(predecessor => dp.ContainsKey(predecessor) ? dp[predecessor] : dp[predecessor] = GetLongestChain(predecessor))
                    .Append(0)
                    .Max();
    }
}
