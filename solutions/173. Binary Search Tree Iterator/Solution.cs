/**
 * Definition for a binary tree node.
 * public class TreeNode {
 *     public int val;
 *     public TreeNode left;
 *     public TreeNode right;
 *     public TreeNode(int val=0, TreeNode left=null, TreeNode right=null) {
 *         this.val = val;
 *         this.left = left;
 *         this.right = right;
 *     }
 * }
 */
public class BSTIterator {

    int cur = 0;
    List<int> a = new();
    
    private void TraverseTree(TreeNode cur)
    {
        if (cur is null) return;
        TraverseTree(cur.left);
        a.Add(cur.val);
        TraverseTree(cur.right);
    }
    
    public BSTIterator(TreeNode root) {
        TraverseTree(root);
    }
    
    public int Next() {
        cur++;
        return a[cur - 1];
    }
    
    public bool HasNext() {
        return cur < a.Count;
    }
}

/**
 * Your BSTIterator object will be instantiated and called as such:
 * BSTIterator obj = new BSTIterator(root);
 * int param_1 = obj.Next();
 * bool param_2 = obj.HasNext();
 */
 