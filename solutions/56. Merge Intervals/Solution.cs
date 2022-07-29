public class Solution {
    public int[][] Merge(int[][] intervals) {
        Array.Sort(intervals, new IntervalsComparator());
        
        List<int[]> result = new();
        
        int left = intervals[0][0];
        int right = intervals[0][1];
        
        foreach (var interval in intervals)
        {
            if (interval[0] <= right)
            {
                right = Math.Max(right, interval[1]);
            }
            else
            {
                result.Add(new int[] { left, right });
                
                left = interval[0];
                right = interval[1];
            }
        }
        
        result.Add(new int[] { left, right });
        
        return result.ToArray();
    }
    
    private class IntervalsComparator : IComparer<int[]>
    {
        public int Compare(int[] a, int[] b)
        {
            if (a[0] == b[0])
            {
                return a[1] - b[1];
            }
            return a[0] - b[0];
        }
    }
}
