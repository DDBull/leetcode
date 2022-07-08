// Didn't solve myself. Read & Understood solution
public class Solution 
{
    private int[,,] memo = new int[100,100,21];
    private const int MAX_COST = 1000001;
    
    public int MinCost(int[] houses, int[][] cost, int m, int n, int target) {
        for (int i = 0; i < 100; i++)
            for (int j = 0; j < 100; j++)
                for (int k = 0; k < 21; k++)
                    memo[i, j, k] = -1;
        
        int ans = FindMinCost(houses, cost, target, 0, 0, 0);
        return ans == MAX_COST ? -1 : ans;
    }
    
    private int FindMinCost(int[] houses, int[][] cost, int targetCount, int currIndex, int neighborhoodCount, int prevHouseColor)
    {
        if (currIndex == houses.Length) return neighborhoodCount == targetCount ? 0 : MAX_COST;
        if (neighborhoodCount > targetCount) return MAX_COST;
        if (memo[currIndex, neighborhoodCount, prevHouseColor] != -1) return memo[currIndex, neighborhoodCount, prevHouseColor];
        
        int minCost = MAX_COST;
        
        if (houses[currIndex] != 0) {
            int newNeighborhoodCount = neighborhoodCount + (houses[currIndex] != prevHouseColor ? 1 : 0);
            minCost = FindMinCost(houses, cost, targetCount, currIndex + 1, newNeighborhoodCount, houses[currIndex]);
        } 
        else {
            int totalColors = cost[0].Length;
            
            for (int color = 1; color <= totalColors; color++)
            {
                int newNeighborhoodCount = neighborhoodCount + (color != prevHouseColor ? 1 : 0);
                int currCost = cost[currIndex][color - 1] 
                    + FindMinCost(houses, cost, targetCount, currIndex + 1, newNeighborhoodCount, color);
                minCost = Math.Min(minCost, currCost);
            }
        }
        
        return memo[currIndex, neighborhoodCount, prevHouseColor] = minCost;
    }
}
