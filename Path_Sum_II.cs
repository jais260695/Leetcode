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
    List<List<int>> res = new List<List<int>>();
    List<int> path = new List<int>();
     public void PathSumUtil(TreeNode root, int sum) {
        if(root.left==null && root.right==null)
        {
            path.Add(root.val);
            int c1 = path.Count()-1;
            if(sum==root.val) 
            {
                res.Add(new List<int>(path));
            }
            path.RemoveAt(c1);
            return;
        }
        
        if(root.left!=null)
        {
            path.Add(root.val);
            int c = path.Count()-1;
            PathSumUtil(root.left,sum-root.val);
            path.RemoveAt(c);
        }
        if(root.right!=null)
        {
            path.Add(root.val);
            int c = path.Count()-1;
            PathSumUtil(root.right,sum-root.val);
            path.RemoveAt(c);
        }      
        return;
    }
    public IList<IList<int>> PathSum(TreeNode root, int sum) {
        if(root==null)
        {
            return res.ToList<IList<int>>();;
        }
        
        PathSumUtil(root,sum);
        
        return res.ToList<IList<int>>();
    }
}