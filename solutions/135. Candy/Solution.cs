public class Solution {
    public int Candy(int[] ratings) {
        int n = ratings.Length;
        var ans = new int[n];
        var ind = new int[n];
        var array = new int[n];
        int res = 0;
        
        for (int i = 0; i < n; i++) 
        {
            ind[i] = i;
            array[i] = ratings[i];
        }
        
        Sort(array, ind, 0, n - 1);
        
        for (int i = 0; i < n; i++)
        {
            int cur = ind[i];
            int l = 0;
            int r = 0;
            if (cur > 0 && ratings[cur] > ratings[cur - 1])
            {
                l = ans[cur - 1];
            }
            if (cur + 1 < n && ratings[cur] > ratings[cur + 1])
            {
                r = ans[cur + 1];
            }
            ans[cur] = Math.Max(l, r) + 1;
            res += ans[cur];
        }
               
        return res;
    }
    
    static int Partition(int[] array, int[] ind, int low, int high)
    {
        int pivot = array[high];

        int lowIndex = (low - 1);

        for (int j = low; j < high; j++)
        {
            if (array[j] <= pivot)
            {
                lowIndex++;

                (array[lowIndex], array[j]) = (array[j], array[lowIndex]);
                (ind[lowIndex], ind[j]) = (ind[j], ind[lowIndex]);
            }
        }

        (array[lowIndex + 1], array[high]) = (array[high], array[lowIndex + 1]);
        (ind[lowIndex + 1], ind[high]) = (ind[high], ind[lowIndex + 1]);

        return lowIndex + 1;
    }

    static void Sort(int[] array, int[] ind, int low, int high)
    {
        if (low < high)
        {
            int partitionIndex = Partition(array, ind, low, high);

            Sort(array, ind, low, partitionIndex - 1);
            Sort(array, ind, partitionIndex + 1, high);
        }
    }
}
