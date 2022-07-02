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
    public bool IsSymmetric(TreeNode root) {
        
        List<int> l = new();
        List<int> r = new();
        
        Dfs(root.left, l, true);
        Dfs(root.right, r, false);
        
        if (l.Count != r.Count) return false;
        
        for (int i = 0; i < l.Count; i++)
        {
            if (l[i] != r[i]) return false;
        }
        
        return true;
    }
    
    private void Dfs(TreeNode cur, List<int> ans, bool isLeft)
    {
        if (cur is null) 
        {
            ans.Add(200);
            return;
        }
        ans.Add(cur.val);
        
        if (isLeft)
        {
            Dfs(cur.left, ans, isLeft);
            Dfs(cur.right, ans, isLeft);
        }
        else
        {
            Dfs(cur.right, ans, isLeft);
            Dfs(cur.left, ans, isLeft);
        }
    }
}
