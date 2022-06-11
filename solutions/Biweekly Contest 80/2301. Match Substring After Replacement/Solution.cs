public class Solution {
    public bool MatchReplacement(string s, string sub, char[][] mappings) {
        Dictionary <int, string> dt = new();
        
        for (int i = 0; i < sub.Length; i++)
        {
            dt.Add(i, Char.ToString(sub[i]));
        }
        
        for (int i = 0; i < mappings.Length; i++)
        {
            for (int j = 0; j < sub.Length; j++)
            {
                if (mappings[i][0] == sub[j])
                {
                    dt[j] = dt[j] + Char.ToString(mappings[i][1]);
                }
            }
        }
        
        for (int i = 0; i < s.Length; i++)
        {
            if (i + sub.Length - 1 > s.Length)
            {
                return false;
            }
            
            int j;
            
            for (j = 0; j < sub.Length; j++)
            {
                if (!dt[j].Contains(s[i + j])) break;
            }
            
            if (j == sub.Length) return true;
        }
        
        return false;
    }
}
