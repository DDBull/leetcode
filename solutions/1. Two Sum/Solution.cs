public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        int alength = nums.Length;
        int[] answer = new int[2];
                
        for (int i = 0; i < alength - 1; i++) {
            for (int j = i + 1; j < alength; j++) {
                if (nums[i] + nums[j] == target) {
                    answer[0] = i;
                    answer[1] = j;
                }
            }
        }
        
        return answer;
    }
}
