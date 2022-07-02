public class Solution {
    public int MaxArea(int h, int w, int[] horizontalCuts, int[] verticalCuts) {
        Array.Sort(horizontalCuts);
        Array.Sort(verticalCuts);
        
        int height = horizontalCuts[0];
        int width = verticalCuts[0];
        
        int n = horizontalCuts.Length;
        int m = verticalCuts.Length;
        
        for (int i = 1; i < n; i++)
        {
            height = Math.Max(height, horizontalCuts[i] - horizontalCuts[i - 1]);
        }
        
        height = Math.Max(height, h - horizontalCuts[n - 1]);
        
        for (int j = 1; j < m; j++)
        {
            width = Math.Max(width, verticalCuts[j] - verticalCuts[j - 1]);
        }
        
        width = Math.Max(width, w - verticalCuts[m - 1]);
        
        long ans =  ((long) height) * width  % 1000000007;
        
        return (int) ans;
    }
}
