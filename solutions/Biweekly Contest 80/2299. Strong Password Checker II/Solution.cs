using System.Text.RegularExpressions;

public class Solution {
    public bool StrongPasswordCheckerII(string password) {
        string num = @"[0-9]+";
        string lowercase = @"[a-z]+";
        string uppercase = @"[A-Z]+";
        
        return (Regex.IsMatch(password, num)) && (Regex.IsMatch(password, lowercase)) && (Regex.IsMatch(password, uppercase)) && special(password) && password.Length > 7 && repeatAdjacent(password); 
    }
    
    private bool special(string s)
    {
        string p = "!@#$%^&*()-+";
        
        foreach (char c in p)
        {
            if (s.Contains(c))
            {
                return true;
            }
        }
        
        return false;
            
    }
    
    private bool repeatAdjacent(string s)
    {
        for (int i = 1; i < s.Length; i++)
        {
            if (s[i] == s[i - 1])
            {
                return false;
            }
        }
        
        return true;
    }
}
