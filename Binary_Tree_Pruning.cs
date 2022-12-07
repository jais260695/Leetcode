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
    public TreeNode PruneTree(TreeNode root) {
        if(root==null) return null;
        TreeNode left = PruneTree(root.left);
        TreeNode right = PruneTree(root.right);

        root.left = left;
        root.right = right;
        
        if(left!=null || right!=null)
        {
            return root;
        }

        return root.val==0 ? null : root;

    }
}