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
    public bool HasPathSumUtil(TreeNode root, int sum) {
        if(root.left==null && root.right==null)
        {
            if(sum==root.val) return true;
            return false;
        }
        
        if((root.left!=null && HasPathSumUtil(root.left,sum-root.val)) || (root.right!=null && HasPathSumUtil(root.right,sum-root.val)))
        {
            return true;
        }
        
        return false;
    }
    public bool HasPathSum(TreeNode root, int sum) {
        if(root==null)
        {
            return false;
        }
        
        return HasPathSumUtil(root,sum);
    }
}