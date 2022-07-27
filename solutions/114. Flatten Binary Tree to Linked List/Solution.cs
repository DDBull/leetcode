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
// DSM
public void Flatten(TreeNode root) 
{
	TreeNode tree = root;

	while(tree != null)
	{
		if(tree.left != null)
		{            
			var predecessor = tree.left;

			while(predecessor.right != null)
			{
				predecessor = predecessor.right;
			}

			predecessor.right = tree.right;
			tree.right = tree.left;
			tree.left = null;
		}

		tree = tree.right;
	}
}

}
