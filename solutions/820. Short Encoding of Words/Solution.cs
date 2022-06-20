public class Solution {
    public int MinimumLengthEncoding(string[] words) {
        int n = words.Length;
        bool[] state = new bool[n];
        
        for (int i = 0; i < n; i++)
        {
            if (!state[i]) {
                for (int j = 0; j < n; j++)
                {
                    if (i != j && !state[j] && words[i].EndsWith(words[j]))
                    {
                        state[j] = true;
                    }
                }
            }
        }
        
        int ans = 0;
        
        for (int i = 0; i < n; i++)
        {
            if (!state[i])
            {
                ans += 1 + words[i].Length;
            }
        }
        
        return ans;
    }
}
