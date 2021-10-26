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
    public IList<IList<int>> ZigzagLevelOrder(TreeNode root) {
        List<List<int>> result = new List<List<int>>();
        if(root==null) return result.ToList<IList<int>>();
        
        Stack<TreeNode> q  = new Stack<TreeNode>();
        Stack<TreeNode> s  = new Stack<TreeNode>();
        
        q.Push(root);
        
        while(q.Count()>0 || s.Count()>0)
        {
            List<int> res = new List<int>();
            while(q.Count()>0)
            {
                TreeNode temp = q.Pop();
                res.Add(temp.val);
                    if(temp.left!=null)
                    {
                       s.Push(temp.left);
                    }
                    if(temp.right!=null)
                    {
                       s.Push(temp.right);
                    }
            }
            if(res.Count()>0)
                result.Add(res);
            res = new List<int>();
            while(s.Count()>0)
            {
                TreeNode temp = s.Pop();
                res.Add(temp.val);
                    if(temp.right!=null)
                    {
                       q.Push(temp.right);
                    }
                    if(temp.left!=null)
                    {
                       q.Push(temp.left);
                    }
            }
            if(res.Count()>0)
                result.Add(res);
            
        }
        return result.ToList<IList<int>>();
    }
}