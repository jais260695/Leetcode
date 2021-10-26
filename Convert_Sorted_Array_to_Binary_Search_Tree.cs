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
    public TreeNode BalanceTree(int l, int h, int[] nums)
    {
        if(l>h) return null;
        int mid = l+(h-l)/2;
        TreeNode root = new TreeNode(nums[mid]);
        root.left = BalanceTree(l,mid-1,nums);
        root.right = BalanceTree(mid+1,h,nums);
        return root;
    }
    public TreeNode SortedArrayToBST(int[] nums) {
        int n = nums.Count();
        return BalanceTree(0,n-1,nums);
    }
}