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
    int res = 0;
    public void DFS(TreeNode root, int max)
    {
        if(root.val>=max)
        {
            res++;
            max = root.val;
        }
        
        if(root.left!=null)
        {
            DFS(root.left,max);
        }
        
        if(root.right!=null)
        {
            DFS(root.right,max);
        }
    }
    public int GoodNodes(TreeNode root) {
        DFS(root,int.MinValue);
        return res;
    }
}