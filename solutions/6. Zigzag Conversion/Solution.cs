public class Solution {
    public string Convert(string s, int numRows) {
        StringBuilder[] zigzag = new StringBuilder[numRows + 1];
        
        for (int i = 1; i <= numRows; i++)
        {
            zigzag[i] = new StringBuilder();
        }
        
        if (numRows == 1) 
        {
            return s;
        }
        
        int cur = 1;
        int idx = 0;
        bool asc = true;
        
        while (idx < s.Length)
        {
            zigzag[cur].Append(s[idx]);
            idx++;
            
            if (asc)
            {
                cur++;
                if (cur > numRows)
                {
                    cur = numRows - 1;
                    asc = !asc;
                }
            }
            else
            {
                cur--;
                if (cur == 0)
                {
                    cur = 2;
                    asc = !asc;
                }
            }
        }
        
        string ans = string.Empty;
        
        for (int i = 1; i <= numRows; i++)
        {
            ans = ans + zigzag[i].ToString();
        }
        
        return ans;
    }
}
