public class Solution {
    public int Compress(char[] chars) {
        int cur = 1;
        int result = 0;
        string temp = string.Empty;
        
        for (int i = 0; i < chars.Length; i++)
        {
            if (i + 1 < chars.Length && chars[i] != chars[i + 1])    
            {
                result++;
                temp += $"{chars[i]}";
                
                if (cur > 1)
                {
                    temp += $"{cur}";
                
                    while (cur > 0)
                    {
                        result++;
                        cur /= 10;
                    }    
                }

                cur = 0;
            }
            else if (i + 1 == chars.Length)
            {
                result++;
                temp += $"{chars[i]}";
                
                if (cur > 1)
                {
                    temp += $"{cur}";
                
                    while (cur > 0)
                    {
                        result++;
                        cur /= 10;
                    }    
                }
            }
            cur++;
        }
        
        for (int i = 0; i < result; i++)
        {
            chars[i] = temp[i];
        }
        
        return result;
    }
}
