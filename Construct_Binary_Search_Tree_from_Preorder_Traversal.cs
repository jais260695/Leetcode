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
    public int FindFirstGreater(int l, int h, int val, int[] arr)
    {
        while(l<=h && arr[l]<val)
        {
             l++;  
        }        
        return l;
    }
    
    public TreeNode ConstructBST(int l,int h,int[] preorder)
    {
        if(l>h) return null;
        TreeNode root = new TreeNode(preorder[l]);        
        int partition = FindFirstGreater(l+1,h,preorder[l],preorder);       
        root.left = ConstructBST(l+1,partition-1, preorder);
        root.right = ConstructBST(partition,h, preorder);        
        return root;        
    }
    public TreeNode BstFromPreorder(int[] preorder) {
        int n = preorder.Count();
        return ConstructBST(0,n-1,preorder);
    }
}