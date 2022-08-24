public class Solution {
    public bool IsPowerOfThree(int n) {
        return (Math.Log10(n) / Math.Log10(3)) % 1 == 0;
    }
}
