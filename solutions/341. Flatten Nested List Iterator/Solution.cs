/**
 * // This is the interface that allows for creating nested lists.
 * // You should not implement it, or speculate about its implementation
 * interface NestedInteger {
 *
 *     // @return true if this NestedInteger holds a single integer, rather than a nested list.
 *     bool IsInteger();
 *
 *     // @return the single integer that this NestedInteger holds, if it holds a single integer
 *     // Return null if this NestedInteger holds a nested list
 *     int GetInteger();
 *
 *     // @return the nested list that this NestedInteger holds, if it holds a nested list
 *     // Return null if this NestedInteger holds a single integer
 *     IList<NestedInteger> GetList();
 * }
 */
public class NestedIterator {
    List<int> list;
    int iterator;

    public NestedIterator(IList<NestedInteger> nestedList) {
        this.list = new();
        this.iterator = 0;
        
        FlattenList(list, nestedList);
    }

    public bool HasNext() {
        return iterator < list.Count;
    }

    public int Next() {
        return list[iterator++];
    }
    
    private void FlattenList(List<int> list, IList<NestedInteger> nestedList)
    {
        foreach (var ni in nestedList)
        {
            if (ni.IsInteger())
            {
                list.Add(ni.GetInteger());
            }
            else
            {
                FlattenList(list, ni.GetList());
            }
        }
    }
}

/**
 * Your NestedIterator will be called like this:
 * NestedIterator i = new NestedIterator(nestedList);
 * while (i.HasNext()) v[f()] = i.Next();
 */