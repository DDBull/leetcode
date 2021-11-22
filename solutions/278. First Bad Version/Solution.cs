/* The isBadVersion API is defined in the parent class VersionControl.
      bool IsBadVersion(int version); */

public class Solution : VersionControl {
    public int FirstBadVersion(int n) {
        int left = 1;
        int right = n;
        
        while (left <= right)
        {
          int middle = (int) (((long) left + right) / 2L);

          if (IsBadVersion(left))
          {
            return left;
          } else if (IsBadVersion(middle))
          {
            right = middle;
          } else 
          {
            left = middle + 1;
          }
        }

        return n;
    }
}
