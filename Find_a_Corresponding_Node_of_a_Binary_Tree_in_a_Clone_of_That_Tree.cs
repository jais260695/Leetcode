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
    public TreeNode GetTargetCopy(TreeNode original, TreeNode cloned, TreeNode target) {
        if(original==null) return null;
        if(original==target) return cloned;
        TreeNode result = GetTargetCopy(original.left,cloned.left,target);
        if(result!=null)
        {
            return result;
        }
        return GetTargetCopy(original.right,cloned.right,target);
    }
}