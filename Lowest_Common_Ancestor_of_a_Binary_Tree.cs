/**
 * Definition for a binary tree node.
 * public class TreeNode {
 *     public int val;
 *     public TreeNode left;
 *     public TreeNode right;
 *     public TreeNode(int x) { val = x; }
 * }
 */
public class Solution {
    public TreeNode LowestCommonAncestor(TreeNode root, TreeNode p, TreeNode q) {
        if(root==null) return null;
        if(root==p || root==q) return root;
        TreeNode l = LowestCommonAncestor(root.left, p, q);
        TreeNode r = LowestCommonAncestor(root.right, p, q);
        if(l==null && r==null) return null;
        if(l==null) return r;
        if(r==null) return l;
        return root;
    }
}