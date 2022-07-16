public class Solution {
    public int MySqrt(int t) {
        long x = t;
        long l = 0;
        long r = x;
        
        while (l < r)
        {
            long m = l + (r - l) / 2;
            
            if (m * m == x) return (int) m;
            if (m * m > x) r = m - 1; else l = m + 1;
        }
        
        return (int) (l * l <= x ? l : l - 1);
    }
}
