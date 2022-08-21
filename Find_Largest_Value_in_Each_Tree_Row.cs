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
    public IList<int> LargestValues(TreeNode root) {
        List<int> result = new List<int>();     
        
        if(root==null)
        {
            return result.ToList<int>();
        }
        
        Queue<TreeNode> queue = new Queue<TreeNode>();        
        queue.Enqueue(root);       
        
        while(queue.Count()>0)
        {         
            int max = int.MinValue;
            
            int size = queue.Count();   
            while(size>0)
            {
                TreeNode t = queue.Dequeue();    
                
                max = Math.Max(t.val,max);
                
                if(t.left!=null)
                {
                    queue.Enqueue(t.left);
                }
                
                if(t.right!=null)
                {
                    queue.Enqueue(t.right);
                }
                
                size--;
            }
            
            result.Add(max);
        }
        
        return result.ToList<int>();
    }
}