public class Solution {
    public int[][] IntervalIntersection(int[][] firstList, int[][] secondList) {
        int p1 = 0;
        int p2 = 0;
        List<int[]> ans = new();
        
        while (p1 < firstList.Length && p2 < secondList.Length)
        {
            int s1 = firstList[p1][0];
            int f1 = firstList[p1][1];
            int s2 = secondList[p2][0];
            int f2 = secondList[p2][1];
            
            if (f1 < s2)
            {
                p1++;
            }
            else if (f2 < s1)
            {
                p2++;
            }
            else
            {
                if (f1 <= f2)
                {
                    p1++;
                    s1 = Math.Max(s1, s2);
                    ans.Add(new int[] {s1, f1});
                }
                else
                {
                    p2++;
                    s2 = Math.Max(s1, s2);
                    ans.Add(new int[] {s2, f2});
                }
            }
        }
        
        return ans.ToArray();
    }
}
