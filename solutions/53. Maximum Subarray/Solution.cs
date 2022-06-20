public class Solution {
    public int MaxSubArray(int[] nums) {
        int currentStreak = int.MinValue;
        int ans = int.MinValue;
        
        foreach (int num in nums) {
            if (num >= 0) {
                if (currentStreak >= 0) {
                    currentStreak += num;
                } else {
                    currentStreak = num;
                }
            } else {
                if (currentStreak < num) {
                    currentStreak = num;
                } else {
                    currentStreak += num;    
                }
            }
            ans = ans < currentStreak ? currentStreak : ans;
        }
        
        return ans;
    }
}
