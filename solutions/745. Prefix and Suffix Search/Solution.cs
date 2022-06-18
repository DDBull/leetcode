public class WordFilter {
    
    Dictionary<string, int> dt = new();

    public WordFilter(string[] words) {
        for (int w = 0; w < words.Length; w++)
        {
            int n = words[w].Length;
            for (int i = 0; i <= n; i++)
            {
                for (int j = 0; j <= n; j++)
                {
                    string s = words[w].Substring(0, i) + "#" + words[w].Substring(n - j);
                    dt[s] = w;
                }
            }
        }
    }
    
    public int F(string prefix, string suffix) {
        return dt.ContainsKey(prefix + "#" + suffix) ? dt[prefix + "#" + suffix] : -1;
    }
}

/**
 * Your WordFilter object will be instantiated and called as such:
 * WordFilter obj = new WordFilter(words);
 * int param_1 = obj.F(prefix,suffix);
 */
 