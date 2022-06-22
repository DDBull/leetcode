public class Solution {
    public int FindKthLargest(int[] nums, int k) {
        PriorityQueue <int, int> heap = new();
        
        foreach (int num in nums)
        {
            heap.Enqueue(num, -num);
        }
        
        int cur = 0;
        
        while (k-- > 0)
        {
            cur = heap.Dequeue();
        }
        
        return cur;
    }
}
