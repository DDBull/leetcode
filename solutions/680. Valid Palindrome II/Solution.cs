public class Solution 
{
    public bool ValidPalindrome(string s) 
    { 
      int l = 0;
      int n = s.Length;
      int r = n - 1;

      while (l < r) 
      {
        if (s[l] == s[r])
        {
          l++;
          r--;
        } else 
        {
          int l2 = l + 1;
          int r2 = r;

          while ((l2 < r2) && s[l2] == s[r2]) 
          {
            l2++;
            r2--;
          }

          if (l2 >= r2) return true;

          l2 = l;
          r2 = r - 1;

          while ((l2 < r2) && s[l2] == s[r2]) 
          {
            l2++;
            r2--;
          }

          return (l2 >= r2);
        } 
      }

      return true;
    }
}
