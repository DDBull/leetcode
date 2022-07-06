public class Solution {
    public IList<IList<int>> ThreeSum(int[] nums) {
        HashSet<string> res = new();
        HashSet<int> st = new();
        List<IList<int>> ans = new();
        int n = nums.Length;
        
        Array.Sort(nums);
        
        for (int i = 0; i < n; i++)
        {
            st.Add(nums[i]);
        }
        
        for (int i = 0; i + 2 < n; i++)
        {
            for (int j = i + 1; j + 1 < n; j++)
            {
                if (st.Contains(-(nums[j] + nums[i])))
                {
                    if (Array.BinarySearch(nums, j + 1, n - (j + 1), -(nums[j] + nums[i])) >= 0)
                    {
                        int a = nums[i];
                        int b = nums[j];
                        int c = -(nums[j] + nums[i]);

                        string cur = $"{a}|{b}|{c}";
                        if (!res.Contains(cur))
                        {
                            res.Add(cur);
                            ans.Add(new List<int>(){a, b, c});
                        }
                    }
                }
            }
        }
            
        return ans;    
    }
}
