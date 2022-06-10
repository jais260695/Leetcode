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
    TreeNode  first = null;
    TreeNode second = null;
    TreeNode temp1 = new TreeNode(int.MinValue);
    TreeNode temp2 = new TreeNode(int.MinValue);
    public void InOrder(TreeNode root)
    {
        if(root!=null)
        {
        
            InOrder(root.left);

            if(temp2.val>root.val && temp2.val>temp1.val && first==null)
            {
                first = temp2;
            }
            
            if(temp2.val<root.val && temp2.val<temp1.val)
            {
                second = temp2;
            }

            temp1 = temp2;
            temp2 = root;
            InOrder(root.right);
        }
    }
        
    public void RecoverTree(TreeNode root) {
        InOrder(root);
        
        if(temp2.val<temp1.val) second = temp2;
        
        int temp = first.val;
        first.val = second.val;
        second.val = temp;
    }
}