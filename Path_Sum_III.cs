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
    public int PathSumUtil(TreeNode root, long targetSum) {
        if(root==null) return 0;
        int result = 0;       
        if((targetSum-root.val)==0) result++;
        return result+PathSumUtil(root.left, targetSum-root.val)+PathSumUtil(root.right, targetSum-root.val);
    }

    public int PathSum(TreeNode root, int targetSum) {
        if(root==null) return 0;
        return PathSumUtil(root,targetSum) + PathSum(root.left, targetSum) + PathSum(root.right, targetSum); 
    }
}