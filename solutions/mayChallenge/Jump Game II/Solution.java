class Solution {
    
    public int jump(int[] nums) {
        
        int len = nums.length;
        int[] ans = new int[len];
        
        ans[0] = 0;
        for (int i = 1; i < len; i++) {
            ans[i] = 1_000_000;
        }

        for (int i = 0; i < len - 1; i++) {
            for (int j = 1; j <= nums[i]; j++) {
                if (i + j >= len) {
                    break;
                }

                ans[i + j] = Math.min(ans[i + j], ans[i] + 1);
            }
        }

        return ans[len - 1];
    }
}
