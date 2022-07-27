public class Solution 
{
    public double FindMedianSortedArrays(int[] nums1, int[] nums2) 
    {
        int N = nums1.Length;
        int M = nums2.Length;
        
        if (N > M)
        {
            return FindMedianSortedArrays(nums2, nums1);
        }
        
        int start = 0;
        int end = N;
        
        while (start <= end)
        {
            int partitionX = start + (end - start) / 2;
            int partitionY = (N + M + 1) / 2 - partitionX;
            
            int minX = (partitionX == 0) ? Int32.MinValue : nums1[partitionX - 1];
            int maxX = (partitionX == N) ? Int32.MaxValue : nums1[partitionX];
            int minY = (partitionY == 0) ? Int32.MinValue : nums2[partitionY - 1];
            int maxY = (partitionY == M) ? Int32.MaxValue : nums2[partitionY];
            
            if (minX > maxY)
            {
                end = partitionX - 1;
            }
            else if (minX <= maxY && minY <= maxX)
            {
                if ((M + N) % 2 == 1)
                {
                    return Math.Max(minX, minY);
                }
                else 
                {
                    return (Math.Max(minX, minY) + Math.Min(maxX, maxY)) / 2.0;
                }
            }
            else
            {
                start = partitionX + 1;
            }
        }
        
        throw new Exception();
    }
}
