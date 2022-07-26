public class Solution {
    public int MaxDistToClosest(int[] seats) {
        int result = 1;
        int last = -1; // last person's position
        
        for (int i = 0; i < seats.Length; i++)
        {
            if (seats[i] == 1)
            {
                if (last == -1)
                {
                    result = Math.Max(result, i);
                }
                else
                {
                    result = Math.Max(result, (i - last) / 2);
                }
                    
                last = i;
            }
        }
        
        if (seats[seats.Length - 1] == 0)
        {
            result = Math.Max(result, (seats.Length - 1) - last);
        }
        
        return result;
    }
}
