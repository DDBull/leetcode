public class Solution {
    public int[] SortedSquares(int[] nums) {
        int n = nums.Length;
        Stack<int> st = new();
    
        int l = 0, r = n - 1;
    
        while (l <= r)
        {
            if (nums[l] * nums[l] >= nums[r] * nums[r])    
            {
                st.Push(nums[l] * nums[l]);
                l++;
            }
            else
            {
                st.Push(nums[r] * nums[r]);
                r--;
            }
        }
    
        List<int> ans = new();
    
        while (st.Count > 0)
        {
            ans.Add(st.Pop());
        }
    
        return ans.ToArray();
    }
}
