public class Solution {
    private const int MAX_CHAR = 'z';
    private const int MIN_CHAR = 'A';
    
    public string MinWindow(string s, string t) {
        string minWindow = s + "!";
        
        if (t.Length > s.Length) 
        {
            return string.Empty;
        }

        int[] tLettersCount = new int[MAX_CHAR + 1];
        int[] sLettersCount = new int[MAX_CHAR + 1];
        
        foreach (char ch in t)
        {
            tLettersCount[ch]++;
        }
        
        int left = 0;
        for (int right = 0; right < s.Length; right++)
        {
            sLettersCount[s[right]]++;
            
            if (right >= t.Length - 1 && sLettersCount[s[right]] >= tLettersCount[s[right]] && IsSubstring(tLettersCount, sLettersCount))
            {
                if (right - left + 1 < minWindow.Length)
                {
                    minWindow = s.Substring(left, right - left + 1);
                }
                
                while (left <= right)
                {
                    if (sLettersCount[s[left]] - 1 >= tLettersCount[s[left]])
                    {
                        sLettersCount[s[left]]--;
                        left++;
                    }
                    else
                    {
                        if (right - left + 1 < minWindow.Length)
                        {
                            minWindow = s.Substring(left, right - left + 1);
                        }
                        break;
                    }
                }
            }
        }
        
        return minWindow.Length > s.Length ? string.Empty : minWindow;
    }
    
    private bool IsSubstring(int[] tLettersCount, int[] sLettersCount)
    {
        for (int i = MIN_CHAR; i <= MAX_CHAR; i++)
        {
            if (tLettersCount[i] > sLettersCount[i])
            {
                return false;
            }
        }
        return true;
    }
}
