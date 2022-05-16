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
    public int[] Solve(TreeNode root)
    {
        if(root==null)
        {
            return new int[2]{0,0}; 
        }
        int[] left  = Solve(root.left);
        int[] right = Solve(root.right);
        int count = 1 + left[0] + right[0];
        int sum = root.val + left[1] + right[1];
        
        int avg = sum/count;
        if(avg == root.val) result++;
        
        return new int[2]{count,sum};
    }
    public int AverageOfSubtree(TreeNode root) {
        
        Solve(root);
        return result;
    }
}