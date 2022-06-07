public class Solution {
    public void Merge(int[] nums1, int m, int[] nums2, int n) {
        int[] merged = new int[n + m];
        int p1 = 0;
        int p2 = 0;
        int cur = 0;
        
        while (p2 < n || p1 < m)
        {
            if (p1 >= m)
            {
                merged[cur++] = nums2[p2++];
            } else
            if (p2 >= n)
            {
                merged[cur++] = nums1[p1++];
            } else
            if (nums1[p1] <= nums2[p2])
            {
                merged[cur++] = nums1[p1++];
            } else
            {
                merged[cur++] = nums2[p2++];
            }
        }
        
        for (int i = 0; i < n + m; i++) nums1[i] = merged[i];
    }
}
