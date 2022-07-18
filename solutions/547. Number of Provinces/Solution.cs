public class Solution {
    public int FindCircleNum(int[][] isConnected) {
        int n = isConnected.Length;
        int[] province = new int[n];
        int ans = 0;
        Queue<int> q = new();
        
        for (int i = 0; i < n; i++)
        {
            if (province[i] == 0)
            {
                province[i] = ++ans;
                q.Enqueue(i);
                
                while (q.Count > 0)
                {
                    int cur = q.Dequeue();
                    
                    for (int j = 0; j < n; j++)
                    {
                        if (province[j] == 0 && isConnected[cur][j] == 1)
                        {
                            province[j] = ans;
                            q.Enqueue(j);
                        }
                    }
                }
            }
        }
        
        return ans;
    }
}
