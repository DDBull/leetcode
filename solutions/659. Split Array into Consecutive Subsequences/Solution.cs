public class Solution {
    public bool IsPossible(int[] nums) {
        var left = new Dictionary<int, int> ();
        var end = new Dictionary<int, int> ();
        
        foreach (int num in nums)
        {
            left.TryAdd(num, 0);
            left[num]++;
        }
        
        foreach (int num in nums)
        {
            if (!left.ContainsKey(num)) continue;
            
            left[num]--;
            
            if (left[num] == 0)
            {
                left.Remove(num);
            }
            
            if (end.ContainsKey(num - 1))
            {
                end.TryAdd(num, 0);
                end[num]++;
                end[num - 1]--;
                
                if (end[num - 1] == 0)
                {
                    end.Remove(num - 1);
                }
            }
            else if (left.ContainsKey(num + 1) && left.ContainsKey(num + 2))
            {
                left[num + 1]--;
                left[num + 2]--;
                
                if (left[num + 1] == 0)
                {
                    left.Remove(num + 1);
                }
                if (left[num + 2] == 0)
                {
                    left.Remove(num + 2);
                }
                
                end.TryAdd(num + 2, 0);
                end[num + 2]++;
            }
            else
            {
                return false;
            }
        }
        
        return true;
    }
}
