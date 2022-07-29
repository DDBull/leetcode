public class Solution {
    public int MinMeetingRooms(int[][] intervals) {
        List<int> time = new();
        
        foreach (var interval in intervals)
        {
            // odd => start; even => end 
            time.Add(interval[0] * 2);
            time.Add(interval[1] * 2 - 1);
        }
        
        time.Sort();
        
        int result = 0;
        int cur = 0;
        
        foreach (int num in time)
        {
            cur = (num % 2 == 1) ? cur - 1 : cur + 1;
            result = Math.Max(result, cur);
        }
        
        return result;
    }
}
