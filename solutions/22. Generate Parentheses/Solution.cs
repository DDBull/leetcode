public class Solution {
    private List<string> ans;
    
    public IList<string> GenerateParenthesis(int n) {
        ans = new();
	    GenerateP(0, 0, 2 * n, new StringBuilder());    
        return ans;
    }
    
    private void GenerateP(int index, int sum, int n, StringBuilder s)
    {
	    if (index == n && sum == 0)
        {
	        ans.Add(s.ToString());
            return;
        }
        if (sum < 0 || sum > n / 2 || index == n)
        {
	        return;
        }

        GenerateP(index + 1, sum + 1, n, s.Append("("));
        s.Remove(s.Length - 1, 1);
        GenerateP(index + 1, sum - 1, n, s.Append(")")); 
        s.Remove(s.Length - 1, 1);
    }
}
