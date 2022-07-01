public class Solution {
    public int MaximumUnits(int[][] boxTypes, int truckSize) {
        Array.Sort(boxTypes, (a, b) => {
           return b[1] - a[1]; 
        });
        
        int ans = 0;
        
        foreach (var cur in boxTypes)
        {
            if (truckSize - cur[0] >= 0)
            {
                truckSize -= cur[0];
                ans += cur[1] * cur[0];
            }
            else
            {
                ans += truckSize * cur[1];
                break;
            }
        }
        
        return ans;
    }
}
