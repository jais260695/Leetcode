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
    Dictionary<TreeNode,int> dict =  new  Dictionary<TreeNode,int>();
    
     public int LongestZigZagUtil(TreeNode node, int ind) {
            if(node==null) return 0;
            if(dict.ContainsKey(node)) return dict[node];
            if(ind==0)
            {
                int val = 1+LongestZigZagUtil(node.right,1);
                dict.Add(node,val);
                return val;
            }
            int val1 =  1+LongestZigZagUtil(node.left,0);
            dict.Add(node,val1);
            return val1;
     } 
    
    public int LongestZigZag(TreeNode root) {
            if(root==null) return 0;
            return Math.Max(
                Math.Max(LongestZigZagUtil(root.left,0),LongestZigZagUtil(root.right,1)),
                Math.Max(LongestZigZag(root.left),LongestZigZag(root.right))
            );
    }
}