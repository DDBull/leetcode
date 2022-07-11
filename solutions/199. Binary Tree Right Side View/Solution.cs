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
    List<int> ans = new();
    
    public IList<int> RightSideView(TreeNode root) {
        Dfs(root, 0);
        return ans;
    }
    
    private void Dfs(TreeNode cur, int lvl)
    {
        if (cur is null) return;
        
        if (ans.Count <= lvl)
        {
            ans.Add(cur.val);
        } else
            ans[lvl] = cur.val;
        
        Dfs(cur.left, lvl + 1);
        Dfs(cur.right, lvl + 1);
    }
}
