public class Solution 
{
    public int NumMatchingSubseq(string s, string[] words) 
    {
        int ans = 0;
        int n = s.Length;
        
        Dictionary<char, List<int>> d = new();
        
        for (int i = 0; i < s.Length; i++)
        {
            if (d.ContainsKey(s[i]))
            {
                d[s[i]].Add(i);
            }
            else
            {
                d.Add(s[i], new List<int>());
                d[s[i]].Add(i);
            }
        }
        
        foreach (string word in words)
        {
            int curIndex = -1;
            bool fl = true;
            
            for (int i = 0; i < word.Length && fl; i++)
            {
                if (!d.ContainsKey(word[i]))
                {
                    fl = false;
                }
                else
                {
                    if (curIndex == -1)
                    {
                        curIndex = d[word[i]][0] + 1;
                        //if (word == "bb") Console.WriteLine(d[word[i]][0]);
                        continue;
                    }
                    List<int> indexes = d[word[i]];
                    int l = 0;
                    int r = indexes.Count - 1;
                    
                    while (l < r)
                    {
                        int m = (l + r) / 2;
                        
                        if (indexes[m] == curIndex)
                        {
                            l = m;
                            r = m;
                        } 
                        else if (indexes[m] < curIndex)
                        {
                            l = m + 1;
                        }
                        else 
                        {
                            r = m;
                        }
                    }
                    
                    if (indexes[l] >= curIndex)
                    {
                        curIndex = indexes[l] + 1; 
                        //if (word == "bb") Console.WriteLine(indexes[l]);
                    }
                    else 
                    {
                        fl = false;
                    }
                }
            }
            
            if (fl) 
            {
                ans++;
            }
        }
        
        return ans;
    }
}
