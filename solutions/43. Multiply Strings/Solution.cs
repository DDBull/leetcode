 public class Solution
  {
    public string Multiply(string num1, string num2)
    {
      int m = num1.Length;
      int n = num2.Length;
      int[] result = new int[m + n];
        
      for (int i = n - 1; i >= 0; i--)
      {
        for (int j = m - 1; j >= 0; j--)
        {
          int multi = (num1[j] - '0') * (num2[i] - '0');
          int sum = multi + result[i + j + 1];

          result[i + j] += sum / 10; // always put the div + current index value, in second last position
          result[i + j + 1] = sum % 10; // remainder at last position

        }
      }

      StringBuilder str = new StringBuilder();
    
        int cur = 0;
        
      while (cur < result.Length && result[cur] == 0) 
      {
          cur++;
      }
        
        if (cur == result.Length)
        {
            return "0";
        }
        
      for (int i = cur; i < result.Length; i++)
      {
        if (i == 0 && result[i] == 0) continue;
        str.Append(result[i]);
      }
      return str.ToString();
    }
  }
