public class Solution {
    public int[][] ReconstructQueue(int[][] people)
        => people
			// at first sort people by height in descending order, then by position in ascending order
            .OrderBy(x => (-x[0], x[1]))
			// process people by inserting each person at corresponding position in the resulting list
            .Aggregate(new List<int[]>(), (list, person) => { list.Insert(person[1], person); return list; })
            .ToArray();
}
// Didn't solve myself
