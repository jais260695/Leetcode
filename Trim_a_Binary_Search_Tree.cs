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
    public TreeNode TrimBST(TreeNode root, int L, int R) {
        if(root==null) return null;
        root.left = TrimBST(root.left,L,R);
        root.right = TrimBST(root.right,L,R);
        
        if(root.val<L)
        {
            TreeNode node = root.right;
            root = null;
            return node;
        }
        if(root.val>R)
        {
            TreeNode node = root.left;
            root = null;
            return node;
        }
        
        return root;
            
    }
}