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
    
    public bool IsValidBSTUtil(TreeNode root, int min, int max)
    {
        if(root==null)
            return true;
        if(root.val<min || root.val>max)
            return false;
        if(IsValidBSTUtil(root.left,min,root.val-1) && IsValidBSTUtil(root.right,root.val+1,max))
            return true;
        return false;
    }
    
    public bool IsValidBST(TreeNode root) {
        
        if(root==null) return true;
        
        if((root.left!=null && root.val<=root.left.val) || (root.right!=null && root.val>=root.right.val))
            return false;
        if(root.val == int.MinValue && root.right!=null && root.right.right!=null && root.right.right.val==int.MinValue) return false;
        return IsValidBSTUtil(root,int.MinValue,int.MaxValue);
        
    }
}