public class Solution {
    public int FindMaxConsecutiveOnes(int[] nums) {
        int zeroesCanBeFlipped = 1;
        Queue<int> zeroIndices = new();
        int startIdx = 0;
        int endIdx = 0;
        int result = 0;
        
        while (endIdx < nums.Length)
        {
            if (nums[endIdx] == 0)
            {
                zeroIndices.Enqueue(endIdx);
            }
            
            if (zeroIndices.Count > zeroesCanBeFlipped)
            {
                startIdx = zeroIndices.Dequeue() + 1;
            }
            
            result = Math.Max(result, endIdx - startIdx + 1);
            endIdx++;
        }
        
        return result;
    }
}
