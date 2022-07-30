public class Solution {
    public int[] Intersection(int[] nums, int[] nums2) {
        List<int> ans = new();
        int[] count = new int[1001];
        int[] count2 = new int[1001];
        
        foreach(int i in nums) count[i]++;
        foreach(int i in nums2) count2[i]++;
        
        for (int i = 0; i <= 1000; i++)
        {  
            if (count[i] > 0 && count2[i] > 0) ans.Add(i);
        }
        
        return ans.ToArray();
    }
}
