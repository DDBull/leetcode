/*
// Definition for a Node.
public class Node {
    public int val;
    public Node left;
    public Node right;
    public Node parent;
}
*/

public class Solution {
    public Node LowestCommonAncestor(Node p, Node q) {
        HashSet<Node> nodes = new();
        
        while (p != null)
        {
            nodes.Add(p);
            p = p.parent;
        }
        
        while (q != null)
        {
            if (nodes.Contains(q))
            {
                return q;
            }
            q = q.parent;
        }
        
        return null;
    }
}