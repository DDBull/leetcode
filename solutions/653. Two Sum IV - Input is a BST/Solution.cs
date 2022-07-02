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
public class Solution {
    HashSet<int> s = new();
    public bool FindTarget(TreeNode root, int k) {
        Dfs(root);
        
        for (int i = -10000; i <= 10000; i++)
        {
            if (s.Contains(i) && s.Contains(k - i) && i != k - i) return true;
        }
        
        return false;
    }
    
    private void Dfs(TreeNode cur)
    {
        if (cur is null) return;
        s.Add(cur.val);
        Dfs(cur.left);
        Dfs(cur.right);
    }
}
