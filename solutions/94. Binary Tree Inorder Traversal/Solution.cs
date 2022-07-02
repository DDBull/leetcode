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
    public IList<int> InorderTraversal(TreeNode root) {
        List<int> ans = new();
        Stack<TreeNode> st = new();
        
        while ((root is not null) || st.Count > 0)
        {
            while (root is not null)
            {
                st.Push(root);
                root = root.left;
            }
            
            root = st.Pop();
            ans.Add(root.val);
            root = root.right;
        }
        
        return ans;
    }
}
