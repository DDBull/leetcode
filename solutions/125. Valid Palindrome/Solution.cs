public class Solution {
    public bool IsPalindrome(string s) {
        int left = 0;
        int right = s.Length - 1;
        s = s.ToLower();
        
        while (left < right)
        {
            if (!(Char.IsLetter(s[left]) || Char.IsDigit(s[left])))
            {
                left++;
            } 
            else if (!(Char.IsLetter(s[right]) || Char.IsDigit(s[right])))
            {
                right--;
            }
            else
            {
                if (s[left++] != s[right--]) return false;
            }
        }
            
        return true;
    }
}
