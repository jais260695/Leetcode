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
    public int res = 0;
    public int sum = 0;
    public void DFS(TreeNode root)
    {
        sum = sum*10;
        sum+=root.val;
        
        if(root.left==null && root.right==null)
        {
           res+=sum;
           sum-=root.val;
           sum = sum/10; 
           return;
        }
        else
        {
            if(root.left!=null )
                DFS(root.left);
            if(root.right!=null)
                DFS(root.right); 
        }
        sum-=root.val;
           sum = sum/10; 
    }
    public int SumNumbers(TreeNode root) {
        if(root==null) return 0;
        DFS(root);
        return res;
    }
}