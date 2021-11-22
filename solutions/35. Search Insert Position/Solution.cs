public class Solution {
    public int SearchInsert(int[] nums, int target) {
      int left = 0;
      int right = nums.Length - 1;
      
      while (left < right) 
      {
        int middle = (left + right) / 2;

        if (nums[middle] == target)
        {
          return middle;
        } else if (target > nums[middle])
        {
          left = middle + 1;
        } else {
          right = middle - 1;
        }
      }
        
      if (left >= nums.Length) left--;

      return (nums[left] >= target) ? left : left + 1;
    }
}
