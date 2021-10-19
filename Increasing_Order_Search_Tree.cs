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
    TreeNode temp;
    public void InOrder(TreeNode root)
    {
        if(root==null) return;
        InOrder(root.left);
        temp.right = new TreeNode(root.val);
        temp = temp.right;
        InOrder(root.right);
    }
    public TreeNode IncreasingBST(TreeNode root) {
        temp = new TreeNode();
        TreeNode res = temp;//new TreeNode();
        res = temp;
        InOrder(root);
        return res.right;
    }
}