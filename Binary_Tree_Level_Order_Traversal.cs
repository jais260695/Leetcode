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
    public IList<IList<int>> LevelOrder(TreeNode root) {
        List<List<int>> result = new List<List<int>>();
        if(root==null) return result.ToList<IList<int>>();
        TreeNode  sep = new TreeNode(-999999);
        List<int> res = new List<int>();
        Queue<TreeNode> q  = new Queue<TreeNode>();
        
        q.Enqueue(root);
        q.Enqueue(sep);
        
        while(q.Count()>0)
        {
            TreeNode temp = q.Dequeue();
            
            if(temp.val==-999999)
            {
                result.Add(res);
                
                res = new List<int>();
                if(q.Count()==0) break; 
                q.Enqueue(sep);
                continue;
            }
            
            res.Add(temp.val);
            
            if(temp.left!=null)
            {
               q.Enqueue(temp.left);
                
                
            }
            if(temp.right!=null)
            {
               q.Enqueue(temp.right);
            }
            
        }
        return result.ToList<IList<int>>();;
        
    }
}