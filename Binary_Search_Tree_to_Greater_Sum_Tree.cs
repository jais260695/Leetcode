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
    public int sum = 0;
    
    public void SomeOrder(TreeNode root)
    {
        if(root==null) return;
        SomeOrder(root.right);
        sum+=root.val;
        root.val = sum;
        SomeOrder(root.left);
    }
    
    public TreeNode BstToGst(TreeNode root) {
        TreeNode res = root;
        SomeOrder(root);
        return res;
    }
}