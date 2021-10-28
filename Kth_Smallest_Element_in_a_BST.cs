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
    public int i = 0;
    public int res = 0;
    public void InOrder(TreeNode root, int k )
    {
        if(i<k)
        {
            if(root.left != null) 
            {
                InOrder(root.left,k);
            }  
                i++;
                if(i==k) 
                {
                    res = root.val;
                    return;
                }
            if(root.right!=null)
            {
                InOrder(root.right,k);
            }
        }
        return;
    }
    public int KthSmallest(TreeNode root, int k) {
         
         InOrder(root,k);
        return res;
    }
}