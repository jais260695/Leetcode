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
    
    
    public int ans = int.MinValue;
    
    public int MaxPathSumUtil(TreeNode root)
    {
        if(root==null)
        {
            return 0;
        }
        int left= Math.Max(MaxPathSumUtil(root.left),0);
        int right= Math.Max(MaxPathSumUtil(root.right),0);
        
        ans = Math.Max(ans,root.val+left+right);
        
        return Math.Max(left,right)+root.val;
        
    }
    
    public int MaxPathSum(TreeNode root) {
        if(root==null) return 0;
        
        MaxPathSumUtil(root);
        return ans;
        
    }
}