public class Solution {
    public bool IsReflected(int[][] points) {
            if (points is null) return true;

            int minX = Int32.MaxValue;
            int maxX = Int32.MinValue;

            var pointsSet = new HashSet<(int x, int y)>();

            for (int i = 0; i < points.Length; i++)
            {
                int x = points[i][0];
                int y = points[i][1];

                pointsSet.Add((x, y));

                minX = Math.Min(minX, x);
                maxX = Math.Max(maxX, x);
            }

            int lineY = minX + maxX;

            for (int i = 0; i < points.Length; i++)
            {
                int x = points[i][0];
                int y = points[i][1];

                if (!pointsSet.Contains((lineY - x, y)))     
                {
                    return false;
                }
            }

            return true;
    }
}
