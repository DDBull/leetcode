public class Solution {
    public int SingleNumber(int[] nums) {
        int ans = 0;
        
        foreach(var x in nums) ans ^= x;
        
        return ans;
    }
}
