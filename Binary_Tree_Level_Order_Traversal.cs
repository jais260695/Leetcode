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
        
        Queue<TreeNode> q  = new Queue<TreeNode>();        
        q.Enqueue(root);        
        while(q.Count()>0)
        {
            int size = q.Count();
            List<int> res = new List<int>();
            while(size>0)
            {
                TreeNode temp = q.Dequeue();
                res.Add(temp.val);
            
                if(temp.left!=null)
                {
                   q.Enqueue(temp.left);
                }
                
                if(temp.right!=null)
                {
                   q.Enqueue(temp.right);
                }
                size--;
            }
            result.Add(res);
        }
        return result.ToList<IList<int>>();;
        
    }
}