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
    public TreeNode MergeTrees(TreeNode t1, TreeNode t2) {
        
        TreeNode t = new TreeNode();
        
        if(t1!=null && t2!=null)
        {
            t.val = t1.val+t2.val;
            t.left = MergeTrees(t1.left,t2.left);
            t.right = MergeTrees(t1.right,t2.right);
            return t;
        }
        else if(t1!=null)
        {
            t.val = t1.val;
            t.left = MergeTrees(t1.left,null);
            t.right = MergeTrees(t1.right,null);
            return t;
        }
        
        else if(t2!=null)
        {
            t.val = t2.val;
            t.left = MergeTrees(t2.left,null);
            t.right = MergeTrees(t2.right,null);
            return t;
        }
            return null;    
    }
}