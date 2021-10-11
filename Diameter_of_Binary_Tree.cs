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
    
    public int HeightBST(TreeNode root)
    {
        if(root==null) return 0;
         return 1+Math.Max(HeightBST(root.left),HeightBST(root.right));
    }
    
    public int DiameterOfBinaryTree(TreeNode root) {
        if(root==null) return 0;
        int l = HeightBST(root.left);
        int r = HeightBST(root.right);
        
        return Math.Max(l+r,Math.Max(DiameterOfBinaryTree(root.left),DiameterOfBinaryTree(root.right)));
    }
}