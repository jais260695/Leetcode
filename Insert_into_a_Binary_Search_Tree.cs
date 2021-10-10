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
    public TreeNode Insert(TreeNode root, int val)
    {
        if(root==null)
        {
            return new TreeNode(val);
        }
        if(root.val<val)
        {
            root.right = Insert(root.right,val);
        }
        if(root.val>val)
        {
            root.left = Insert(root.left,val);
        }
        
        return root;
    }
    public TreeNode InsertIntoBST(TreeNode root, int val) {
        return Insert(root,val);
    }
}