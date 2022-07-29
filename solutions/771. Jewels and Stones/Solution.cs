public class Solution {
    public int NumJewelsInStones(string jewels, string stones) {
        HashSet<char> set = new();
        
        int result = 0;
        
        foreach (char ch in jewels)
        {
            set.Add(ch);
        }
        
        foreach (char ch in stones)
        {
            if (set.Contains(ch)) result++;
        }
        
        return result;
    }
}
