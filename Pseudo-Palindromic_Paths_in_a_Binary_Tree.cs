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
    int[] digits = new int[10];
    int ans = 0;
    public bool IsPalidrome()
    {
        int oddCount = 0;
        for(int i=1;i<10;i++)
        {
            if(digits[i]%2!=0) oddCount++;
        }
        return oddCount<=1;
    }
    public void Solve(TreeNode root)
    {
        if(root.left==null && root.right==null)
        {
            digits[root.val]++;
            if(IsPalidrome()) ans++;
            digits[root.val]--;
            return;
        }
        
        digits[root.val]++;
        
        if(root.left!=null) Solve(root.left);
        if(root.right!=null) Solve(root.right);
        
        digits[root.val]--;
        
    }
    public int PseudoPalindromicPaths (TreeNode root) {
        Solve(root);
        return ans;
    }
}