public class Solution 
{
    public int CanCompleteCircuit(int[] gas, int[] cost) 
    {
        int n = gas.Length;
        
        int[] gasCircular = new int[2 * n];
        int[] costCircular = new int[2 * n];
        
        for (int i = 0; i < n; i++)
        {
            gasCircular[i] = gas[i];
            gasCircular[i + n] = gas[i];
            costCircular[i] = cost[i];
            costCircular[i + n] = cost[i];
        }
        
        int left = 0;
        
        while (left < n)
        {
            if (gasCircular[left] >= costCircular[left])
            {
                int fuel = 0;
                int tempIndex = left;
                
                for (; tempIndex <= left + n; tempIndex++)
                {
                    fuel += gasCircular[tempIndex];
                    fuel -= costCircular[tempIndex];
                    if (fuel < 0) 
                    {
                        left = tempIndex;
                        break;
                    }
                }
                
                if (tempIndex > left + n)
                {
                    return left;
                }
            }
            left++;
        }
        
        return -1;
    }   
}
