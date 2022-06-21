public class Solution {
    public int FurthestBuilding(int[] heights, int bricks, int ladders) {
        int n = heights.Length;
        PriorityQueue <int, int> heap = new();
        int sum = 0;
        
        for (int i = 0; i + 1 < n; i++)
        {
            if (heights[i] < heights[i + 1])
            {
                int cur = heights[i + 1] - heights[i];
                if (heap.Count < ladders)
                {
                    heap.Enqueue(cur, cur);
                }
                else if (heap.Count > 0 && heap.Peek() < cur)
                {
                    sum += heap.Dequeue();
                    heap.Enqueue(cur, cur);
                }
                else
                {
                    sum += cur;
                }
                if (sum > bricks)
                {
                    return i;
                }
            }
        }
        
        return n - 1;
    }
}
