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
    int count  = 0;
    public int Solve(TreeNode root)
    {
        if(root==null) return 1;
        int left = Solve(root.left);
        int right = Solve(root.right);
        if(left==1 && right==1) return 2;
        if(left==2 || right ==2)
        {
            count++;
            return 3;
        }
        
        return 1;
    }
    public int MinCameraCover(TreeNode root) {
        if(root.left==null && root.right==null) return 1;
        int t = Solve(root);
        if(t==2) count++;
        return count;
    }
}