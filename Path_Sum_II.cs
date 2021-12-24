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
     public void PathSumUtil(TreeNode root, int remainingSum) {
        if(root.left==null && root.right==null)
        {
            path.Add(root.val);
            if(root.val==remainingSum) 
            {
                res.Add(new List<int>(path));
            }
            path.RemoveAt(path.Count()-1);
            return;
        }
        
        if(root.left!=null)
        {
            path.Add(root.val);
            PathSumUtil(root.left,remainingSum-root.val);
            path.RemoveAt(path.Count()-1);
        }
        if(root.right!=null)
        {
            path.Add(root.val);
            PathSumUtil(root.right,remainingSum-root.val);
            path.RemoveAt(path.Count()-1);
        }      
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