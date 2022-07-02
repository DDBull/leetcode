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
    public IList<int> PostorderTraversal(TreeNode root) {
        LinkedList<int> ans = new();
        Stack<TreeNode> st = new();
        
        if (root is null) return ans.ToList();
        
        st.Push(root);
        
        while (st.Count > 0)
        {
            root = st.Pop();
            ans.AddFirst(root.val);
            
            if (root.left is not null) st.Push(root.left);
            if (root.right is not null) st.Push(root.right);
        }
        
        return ans.ToList();
    }
}
