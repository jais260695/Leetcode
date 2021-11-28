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
    public int FindBottomLeftValue(TreeNode root) {
        if(root.left==null && root.right==null) return root.val;
        Queue<TreeNode> queue = new Queue<TreeNode>();
        
        queue.Enqueue(root);
        int ans = -1;
        while(queue.Count()>0)
        {
            TreeNode temp = queue.Dequeue();
            ans = temp.val;
            if(temp.right!=null)
            {
                queue.Enqueue(temp.right);
            }
            
            if(temp.left!=null)
            {
                queue.Enqueue(temp.left);
            }
        }
        return ans;
    }
}