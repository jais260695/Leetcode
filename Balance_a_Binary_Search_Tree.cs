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
    List<TreeNode> inOrder = new List<TreeNode>();
    
    public void InOrder(TreeNode root)
    {
        if(root==null) return;
        
        InOrder(root.left);
        inOrder.Add(root);
        InOrder(root.right);
    }
    
    public TreeNode BalanceTree(int l, int h)
    {
        if(l>h) return null;
        int mid = l+(h-l)/2;
        inOrder[mid].left = BalanceTree(l,mid-1);
        inOrder[mid].right = BalanceTree(mid+1,h);
        return inOrder[mid];
    }
    
    public TreeNode BalanceBST(TreeNode root) {
        InOrder(root);
        int n = inOrder.Count();
        return BalanceTree(0,n-1);
    }
}