public class Solution {
    public string AddStrings(string num1, string num2) {
        
        int n = num1.Length;
        int m = num2.Length;
        
        if (m > n) 
        {
            return AddStrings(num2, num1);
        }
        
        int carryOver = 0;
        int[] result = new int[n];
        
        for (int i = 0; i < n; i++)
        {
            result[i] = carryOver + (num1[n - i - 1] - '0');
            if (m - i - 1 >= 0)
            {
                result[i] += (num2[m - i  - 1] - '0');
            }
            
            carryOver = result[i] / 10;
            result[i] %= 10;
        }
        
        Array.Reverse(result);
        
        StringBuilder ans = new();
        
        if (carryOver > 0) ans.Append('1');
        
        foreach (int num in result)
        {
            ans.Append(num);
        }
        
        return ans.ToString();
    }
}
