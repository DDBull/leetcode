// DSM. U
public class Solution 
{
    public int MaxResult(int[] nums, int k) {
        int n = nums.Length;
        int[] dp = new int[n];
        dp[0] = nums[0];
        LinkedList<int> q = new LinkedList<int>();
        q.AddLast(0);
        
        for (int i = 1; i < n; i++)
        {
            while (i - q.First.Value > k) q.RemoveFirst();
            
            dp[i] = dp[q.First.Value] + nums[i];
            
            while (q.Count > 0 && dp[i] >= dp[q.Last.Value]) q.RemoveLast();
            
            q.AddLast(i);
        }
            
        return dp[n - 1];
    }
}
