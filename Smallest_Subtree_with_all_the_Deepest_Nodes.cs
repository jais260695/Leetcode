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
    public TreeNode SubtreeWithAllDeepest(TreeNode root) {
        
        Queue<TreeNode> queue = new Queue<TreeNode>();        
        queue.Enqueue(root);        
        Dictionary<TreeNode,TreeNode> parent = new Dictionary<TreeNode,TreeNode>();
        List<TreeNode> last = new List<TreeNode>();
        
        while(queue.Count()>0)
        {
            int size = queue.Count();
            last.Clear();
            while(size>0)
            {
                TreeNode t = queue.Dequeue();
                last.Add(t);
                
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
        
        if(last.Count()==1) return last[0];
        
        TreeNode l = last[0];
        TreeNode r = last[last.Count()-1];
        
        while(parent[l]!=parent[r])
        {
            l = parent[l];
            r = parent[r];
        }
        
        return parent[l];
    }
}