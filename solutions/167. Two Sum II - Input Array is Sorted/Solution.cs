public class Solution {
    public int[] TwoSum(int[] numbers, int target) {
        int n = numbers.Length;

        for (int i = 0; i < n; i++)
        {
          int l = i + 1;
          int r = n - 1;
          int t = target - numbers[i];

          while (l <= r)
          {
            int m = (r + l) / 2;
            //Console.WriteLine(i + " " + l + " " + r + " " + t);
            if (numbers[m] == t)
            {
              return new int[] { i + 1 , m + 1 };
            } else if (numbers[m] > t) 
            { 
              r = m - 1;
            } else 
            {
              l = m + 1;
            }
          }
        }

        return new int[] { 1, 10 }; 
    }
}
