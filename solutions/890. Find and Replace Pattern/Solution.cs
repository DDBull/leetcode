public class Solution {
    public IList<string> FindAndReplacePattern(string[] words, string pattern) {
        List<string> result = new();
        
        foreach (string word in words)
        {
            if (Match(word, pattern))
            {
                result.Add(word);
            }
        }
        
        return result;
    }
    
    private bool Match(string word, string pattern)
    {
        Dictionary <char, char> m1 = new();
        Dictionary <char, char> m2 = new();
        
        for (int i = 0; i < word.Length; i++)
        {
            if (!m1.ContainsKey(word[i])) m1.Add(word[i], pattern[i]);
            if (!m2.ContainsKey(pattern[i])) m2.Add(pattern[i], word[i]);
            
            if (m1[word[i]] != pattern[i] || m2[pattern[i]] != word[i])
            {
                return false;
            }
        }
        
        return true;
    }
}
