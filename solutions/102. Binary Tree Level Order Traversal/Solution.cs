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
    public IList<IList<int>> LevelOrder(TreeNode root) {
        List<IList<int>> ans = new();
        Queue<TreeNode> q = new();
        
        if (root is null) return ans;
        
        q.Enqueue(root);
        
        while (q.Count > 0)
        {
            int count = q.Count;
            List<int> cur = new();
            
            for (int i = 0; i < count; i++)
            {
                TreeNode node = q.Dequeue();
                cur.Add(node.val);
                if (node.left is not null)
                {
                    q.Enqueue(node.left);    
                }
                if (node.right is not null)
                {
                    q.Enqueue(node.right);
                }
            }
            
            ans.Add(cur);
        }
        
        return ans;
    }
}
