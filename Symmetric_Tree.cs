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
    
    public bool IsSymmetric(TreeNode root) {
        if(root==null || (root.left==null && root.right==null)) return true;
        Queue<TreeNode> queue1 = new Queue<TreeNode>();
        Queue<TreeNode> queue2 = new Queue<TreeNode>();
        if(root.left!=null && root.right!=null && root.left.val==root.right.val)
        {
            queue1.Enqueue(root.left); 
            queue2.Enqueue(root.right);
        }
        else
        {
            return false;
        }
        while(queue1.Count()>0 || queue2.Count()>0)
        {
            int size1 = queue1.Count();
            int size2 = queue2.Count();
            if(size1!=size2) return false;
            while(size1>0)
            {
                TreeNode node1 = queue1.Dequeue();
                TreeNode node2 = queue2.Dequeue();
                if(node1.left!=null && node2.right!=null && node1.left.val==node2.right.val)
                {
                    queue1.Enqueue(node1.left); 
                    queue2.Enqueue(node2.right);
                }
                else
                {
                     if(!(node1.left==null && node2.right==null))
                     {
                         return false;
                     }
                }
                if(node1.right!=null && node2.left!=null && node1.right.val==node2.left.val)
                {
                    queue1.Enqueue(node1.right); 
                    queue2.Enqueue(node2.left);
                }
                else
                {
                     if(!(node1.right==null && node2.left==null))
                     {
                         return false;
                     }
                }
                size1--;
            }
        }
        return true;
    }
}