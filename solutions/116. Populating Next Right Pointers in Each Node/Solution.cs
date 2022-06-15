/*
// Definition for a Node.
public class Node {
    public int val;
    public Node left;
    public Node right;
    public Node next;

    public Node() {}

    public Node(int _val) {
        val = _val;
    }

    public Node(int _val, Node _left, Node _right, Node _next) {
        val = _val;
        left = _left;
        right = _right;
        next = _next;
    }
}
*/

public class Solution {
    public Node Connect(Node root) {
        Node head = new();
        
        int tp = 1;
        int cnt = 0;
        
        Queue<Node> q = new();
        
        if (root is not null) q.Enqueue(root);
        
        while (q.Count > 0)
        {
            Node cur = q.Dequeue();
            cnt++;
            if (tp == cnt)
            {
                tp *= 2;
                cnt = 0;
            } else {
                cur.next = q.Peek();
            }
            
            if (cur.left is not null) q.Enqueue(cur.left);
            if (cur.right is not null) q.Enqueue(cur.right);
        }
            
        return root;
    }
}
