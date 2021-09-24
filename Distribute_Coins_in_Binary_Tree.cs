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
    int result = 0;
    public int DistributeCoinsUtil(TreeNode root) {
        if(root==null) return 0;
        int leftAns = DistributeCoinsUtil(root.left);
        int rightAns = DistributeCoinsUtil(root.right);
        result += Math.Abs(leftAns) + Math.Abs(rightAns);
        return leftAns + rightAns + root.val  -1;
    }
    public int DistributeCoins(TreeNode root) {
        if(root==null) return 0;
        DistributeCoinsUtil(root);
        return result;
    }
}