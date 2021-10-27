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
    public IList<int> RightSideView(TreeNode root) {
        List<int> res = new List<int>();
        if(root==null) return res.ToList<int>();
        Queue<TreeNode> queue = new Queue<TreeNode>();
        
        queue.Enqueue(root);
        
        while(queue.Count()>0)
        {
            int size = queue.Count();
            int i = 0;
            while(size>0)
            {
                TreeNode temp = queue.Dequeue();
                i = temp.val;
                
                if(temp.left!=null)
                {
                    queue.Enqueue(temp.left);
                }
                
                if(temp.right!=null)
                {
                    queue.Enqueue(temp.right);
                }
                
                size--;
            }
            res.Add(i);
        }
        
        return res.ToList<int>();
    }
}