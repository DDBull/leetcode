public class Solution {
    List<string> ans = new();
    string cur = string.Empty;
    
    public IList<string> LetterCasePermutation(string s) {    
        Compute(0, s);
        return ans;
    }
    
    private void Compute(int k, string s)
    {
        if (k == s.Length)
        {
            ans.Add(new string(cur));
            return;
        }
        
        char c = s[k];
        if (Char.IsLetter(c))
        {
            cur += Char.ToLower(c);
            Compute(k + 1, s);
            cur = k == 0 ? string.Empty : cur.Substring(0, k);
            cur += Char.ToUpper(c);
            Compute(k + 1, s);
            cur = k == 0 ? string.Empty : cur.Substring(0, k);
        }
        else 
        {
            cur += c;
            Compute(k + 1, s);
            cur = k == 0 ? string.Empty : cur.Substring(0, k);
        }
    }
}
