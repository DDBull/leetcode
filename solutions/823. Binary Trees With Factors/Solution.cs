public class Solution {
    public int NumFactoredBinaryTrees(int[] arr) {
        const int MOD = 1000000007;
        Dictionary <int, int> map = new();
        int ans = 0;
        
        Array.Sort(arr);
        
        for (int i = 0; i < arr.Length; i++)
        {
            map.Add(arr[i], 1);
            for (int j = 0; j < i; j++)
            {
                int left = arr[j];
                int right = arr[i] / arr[j];
                
                if (arr[i] % left == 0 && map.ContainsKey(right))
                {
                    if (left == right)
                    {
                        long cur = ((long) map[left]) * map[left] % MOD;
                        map[arr[i]] = (map[arr[i]] + (int) cur) % MOD;    
                    }
                    else
                    {
                        long cur = ((long) map[left]) * map[right] % MOD;
                        map[arr[i]] = (map[arr[i]] + (int) cur) % MOD;    
                    }
                }
            }

            ans = (ans + map[arr[i]]) % MOD;
        }
        
        return ans;
    }
}
