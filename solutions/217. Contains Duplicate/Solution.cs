public class Solution {
    public bool ContainsDuplicate(int[] nums) {
        return nums.GroupBy(x => x).Any(x => x.Count() > 1);
    }
}
