public class Solution {
    public int MinPartitions(string n) {
        return n.ToCharArray().Max() - '0';
    }
}
