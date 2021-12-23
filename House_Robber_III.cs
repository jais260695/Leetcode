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
    Dictionary<TreeNode,int> dp = new Dictionary<TreeNode,int>();
    public int Rob(TreeNode root) {
        if(root==null) return 0;
        
        if(dp.ContainsKey(root)) return dp[root]; 
        
        int result = 0;
        
        //Don't include root
        result = Math.Max(result,Rob(root.left) + Rob(root.right));
         
        //Include root
        result = Math.Max(
                            result,
                            root.val
                            + (root.left==null ? 0 : Rob(root.left.left) + Rob(root.left.right))
                            + (root.right==null ? 0 : Rob(root.right.left) + Rob(root.right.right))
                         );
        
        dp.Add(root,result);
        return result;
    }
}