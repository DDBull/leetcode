public class Solution {
    public int MaximumCandies(int[] candies, long k) {
        int n = candies.Length;
	    int left = 0;
	
	    Array.Sort(candies);
        int right = candies[n - 1];
	    long cur = 0;
        int result = 0;

	    while (left <= right)
        {	
            int middle = left + (right - left) / 2;
            cur = 0;
            
            for (int i = n - 1; i >= 0; i--)
            {
                if (middle != 0) cur += candies[i] / middle; else cur += candies[i];
                
                if (cur >= k) break;	
            }
            
            if (cur < k)
            {
	            right = middle - 1;
            } else
            {
                result = middle;
	            left = middle + 1;
            }
        }

        return result;
    }
}
