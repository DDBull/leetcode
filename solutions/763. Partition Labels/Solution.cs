public class Solution {
    public IList<int> PartitionLabels(string s) {
        int[] letters = new int[26];
        List<int> result = new();
        
        for (int i = 0; i < s.Length; i++)
        {
            letters[s[i] - 'a'] = i;
        }
        
        int left = 0;
        int right = 0;
        
        while (left < s.Length)
        {
            bool flag = false;
            right = letters[s[left] - 'a'];
            int start = left;
            while (left <= right)
            {
                right = Math.Max(right, letters[s[left] - 'a']);
                if (left == right)
                {
                    result.Add(right - start + 1);    
                }
                left++;
                flag = true;
            }
            
            if (!flag) left++;
        }
        
        return result;
    }
}
