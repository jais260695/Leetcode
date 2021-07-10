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
    string result = "";
    public void PreOrder(TreeNode root)
    {
        if(root==null) return;
        
        result = result + root.val;
        
        if(root.left==null &&  root.right==null) return;
        
        result+="(";
        PreOrder(root.left);
        result+=")";

        if(root.right!=null)    
        {
                result+="(";
                PreOrder(root.right);
                result+=")";
        }
    }
    public string Tree2str(TreeNode root) {
        PreOrder(root);
        return result;
    }
}