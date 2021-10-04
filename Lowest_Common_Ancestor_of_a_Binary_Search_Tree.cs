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
        if((p.val<=root.val && q.val>=root.val) || (p.val>=root.val && q.val<=root.val))
        {
            return root;
        }
        if(p.val>root.val && q.val>root.val)
        {
            return LowestCommonAncestor(root.right,p,q);
        }
            return LowestCommonAncestor(root.left,p,q);
        
    }
}