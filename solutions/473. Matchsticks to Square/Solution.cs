// DSM. DU
public class Solution {
    public bool Makesquare(int[] sticks) {
        int sum = sticks.Sum();
        if (sum % 4 != 0) return false;
        int l = sum / 4;
        Array.Sort(sticks);
        Array.Reverse(sticks);
        
        bool Travers(int i, int a, int b, int c, int d)
        {
            if (a > l || b > l || c > l || d > l) return false;
            if (i >= sticks.Length) return a == b && a == c && a == d;
            return 
                Travers(i + 1, a + sticks[i], b, c, d) ||
                Travers(i + 1, a, b + sticks[i], c, d) ||
                Travers(i + 1, a, b, c + sticks[i], d) ||
                Travers(i + 1, a, b, c, d + sticks[i]);
        }
        
        return Travers(0,0,0,0,0);
    }
}
