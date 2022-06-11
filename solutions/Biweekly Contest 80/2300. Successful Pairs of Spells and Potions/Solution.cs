public class Solution {
    public int[] SuccessfulPairs(int[] spells, int[] potions, long success) {
        int n = spells.Length;
        int m = potions.Length;
        
        int[] ans = new int[n];
        int[] pot = new int[100100];
        
        for (int i = 0; i < m; i++)
        {
            pot[potions[i]]++;
        }
        
        for (int i = 1; i <= 100000; i++)
        {
            pot[i] += pot[i - 1];
        }
        
        for (int i = 0; i < n; i++)
        {
            long cur = spells[i];
            cur = success / cur;
            if (success % spells[i] > 0) cur++;
            
            if (cur > 100000)
            {
                ans[i] = 0;
            } else {
                ans[i] = pot[100000] - pot[cur - 1];
            }
        }
        
        return ans;
    }
}
