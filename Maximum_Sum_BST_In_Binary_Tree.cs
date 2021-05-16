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
    
    public int res =0;
    public int ans =0;
    
    public bool IsBST(TreeNode root, int min, int max)
    {
        if(root==null) return true;
        if(root.val>=max || root.val<=min) return false;
        if(IsBST(root.left,min,root.val))
        {
            int temp = res;
            res = 0;
            if(IsBST(root.right,root.val,max))
            {
                res+=root.val;
                res+=temp;
                if(ans<res) ans = res;
                
                return true;
            }
         }
        return false;
    }
    
    public void BSTUtl(TreeNode root)
    {
        if(root==null) return;
        res = 0;
        if(!IsBST(root,int.MinValue,int.MaxValue))
        {
        BSTUtl(root.left);
        BSTUtl(root.right);
        }
    }
    
    public int MaxSumBST(TreeNode root) {
        BSTUtl(root);
        return ans;
    }
}