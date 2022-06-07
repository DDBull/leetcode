public class Solution {
    public int HeightChecker(int[] heights) =>
		heights.OrderBy(h => h)
            .Where((h, i) => heights[i] != h)
            .Count();

    public int HeightChecker(int[] heights) {
        int n = heights.Length;
        int[] expected = new int[n];
        
        Array.Copy(heights, expected, n);
        Array.Sort(expected);
        
        int ans = 0;
        
        for (int i = 0; i < n; i++)
        {
            if (heights[i] != expected[i]) ans++;
        }
        
        return ans;
    }
}
