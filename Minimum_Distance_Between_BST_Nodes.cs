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
    List<int> temp = new List<int>();
    public void inorder(TreeNode root)
    {
        if(root==null) return;
        inorder(root.left);
        temp.Add(root.val);
        inorder(root.right);
    }
    public int MinDiffInBST(TreeNode root) {
        
        inorder(root);
        int ans = int.MaxValue;
        for(int i=1;i<temp.Count();i++)
        {
            if(temp[i]-temp[i-1]<ans) ans = temp[i]-temp[i-1];
        }
        return ans;
        
    }
}