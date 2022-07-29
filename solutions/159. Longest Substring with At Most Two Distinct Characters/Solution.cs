public class Solution {
    public int LengthOfLongestSubstringTwoDistinct(string s) {
        Dictionary<char, int> map = new();
        
        int left = 0;
        int result = 0;
        
        for (int right = 0; right < s.Length; right++)
        {
            if (!map.ContainsKey(s[right]))
            {
                map.Add(s[right], 1);
            }
            else
            {
                map[s[right]]++;
            }
            
            while (left <= right && map.Count > 2)
            {
                map[s[left]]--;
                
                if (map[s[left]] == 0)
                {
                    map.Remove(s[left]);
                }
                left++;
            }
            
            result = Math.Max(result, right - left + 1);
        }
        
        return result;
    }
}
