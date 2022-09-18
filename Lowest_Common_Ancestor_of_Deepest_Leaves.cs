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
    public TreeNode LcaDeepestLeaves(TreeNode root) {
        Queue<TreeNode> queue = new Queue<TreeNode>();        
        queue.Enqueue(root);   
        
        Dictionary<TreeNode,TreeNode> parent = new Dictionary<TreeNode,TreeNode>();
        
        TreeNode left = null;
        TreeNode right = null;
        
        while(queue.Count()>0)
        {
            int size = queue.Count();
            
            left = null;
            right = null;
            
            while(size>0)
            {
                TreeNode t = queue.Dequeue();
                
                if(left==null)
                {
                    left = t;
                    right = t;
                }
                else
                {
                    right = t;
                }
                
                if(t.left!=null)
                {
                    queue.Enqueue(t.left);
                    parent.Add(t.left,t);
                }
                
                if(t.right!=null)
                {
                    queue.Enqueue(t.right);
                    parent.Add(t.right,t);
                }
                size--;
            }
            
        }
        
        if(left==right) return left;
        
        while(parent[left]!=parent[right])
        {
            left = parent[left];
            right = parent[right];
        }
        
        return parent[left];
    }
}