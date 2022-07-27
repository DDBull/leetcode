public class ZigzagIterator {
    Queue<int> v1;
    Queue<int> v2;
    bool onFirst;

    public ZigzagIterator(IList<int> v1, IList<int> v2) {
        this.v1 = new (v1);
        this.v2 = new (v2);
        this.onFirst = true;
    }

    public bool HasNext() {
        return (v1.Count > 0) || (v2.Count > 0);
    }

    public int Next() {
        if (v1.Count > 0 && v2.Count > 0)
        {
            if (onFirst)
            {
                onFirst = false;
                return v1.Dequeue();
            }
            else
            {
                onFirst = true;
                return v2.Dequeue();
            }
        }
        else if (v1.Count > 0)
        {
            return v1.Dequeue();
        }
        else
        {
            return v2.Dequeue();
        }
    }
}

/**
 * Your ZigzagIterator will be called like this:
 * ZigzagIterator i = new ZigzagIterator(v1, v2);
 * while (i.HasNext()) v[f()] = i.Next();
 */