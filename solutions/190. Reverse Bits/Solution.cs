public class Solution {
    public uint reverseBits(uint n) {
        uint res = 0;
        int bits = 31;
        
        while (n != 0)
        {
            res |= (n & 1) << bits--;
            n >>= 1;
        }
        
        return res;
    }
}
