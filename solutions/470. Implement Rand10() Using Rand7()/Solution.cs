/**
 * The Rand7() API is already defined in the parent class SolBase.
 * public int Rand7();
 * @return a random integer in the range 1 to 7
 */
public class Solution : SolBase {
    public int Rand10() {
        int row;
        int col;
        int idx;
        
        do
        {
            row = Rand7();
            col = Rand7();
            idx = row + (col - 1) * 7;
        } while (idx > 40);
        
        return 1 + (idx - 1) % 10;
    }
}
