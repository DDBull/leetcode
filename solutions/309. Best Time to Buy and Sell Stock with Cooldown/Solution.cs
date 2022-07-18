public class Solution 
{

    public int MaxProfit(int[] prices)
    {
	    int ans = 0;
	    int n = prices.Length;
	    int[] dp = new int[n];
        int[] maxSum = new int[n];
	    dp[0] = 0;

	    for (int i = 1;  i < n; i++)
        {	
	        dp[i] = Int32.MinValue;
	    
            for (int j = i - 1; j >= 0; j--)
            {
	            int cur = prices[i] - prices[j];
	            int prevMax = 0;
                if (j - 2 >= 0) prevMax = maxSum[j - 2];
                //for (int k = j - 2; k >= 0; k--) prevMax = Math.Max(prevMax, dp[k]);
            
                dp[i] = Math.Max(dp[i], cur + prevMax);
            }
            
            ans = Math.Max(ans, dp[i]);
            maxSum[i] = ans;
        }

        return ans;
    }
}
