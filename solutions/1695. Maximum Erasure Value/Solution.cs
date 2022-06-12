public class Solution {
    public int MaximumUniqueSubarray(int[] a) {
        HashSet <int> dt = new();
        
        int n = a.Length;
    
        int sum = 0;
        int ans = 0;
        int l = 0;
        
        for (int r = 0; r < n; r++)
        {
            sum += a[r];
            
            if (dt.Contains(a[r]))
            {
                do {
                   sum -= a[l];
                   dt.Remove(a[l]);
                }
                while (a[l++] != a[r]);
            }
            
            dt.Add(a[r]);
            
            ans = Math.Max(ans, sum);
        }
        
        return ans;
    }
}
