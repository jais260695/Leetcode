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
    public int CountNodes(TreeNode root) {
        if(root==null) return 0;
        Queue<TreeNode> queue = new Queue<TreeNode>();
        queue.Enqueue(root);
        int res =0 ;
        while(queue.Count()>0)
        {
            TreeNode temp = queue.Dequeue();
            res++;
            if(temp.left!=null)
                queue.Enqueue(temp.left);
            if(temp.right!=null)
                queue.Enqueue(temp.right);
        }
        return res;
    }
}