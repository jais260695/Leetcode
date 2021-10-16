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
    public int FindMax(int l, int h, int[] nums)
    {
        int max = int.MinValue;
        int index = -1;
        for(int i=l;i<=h;i++)
        {
            if(max<nums[i])
            {
                max = nums[i];
                index = i;
            }
        }
        return index;
    }
    public TreeNode ConstructMaximumBinaryTreeUtil(int l,int h,int[] nums)
    {
        if(l>h) return null;
        int i = FindMax(l,h,nums);
        TreeNode t = new TreeNode(nums[i]);
        t.left = ConstructMaximumBinaryTreeUtil(l,i-1,nums);
        t.right = ConstructMaximumBinaryTreeUtil(i+1,h,nums);
        return t;

    }
    public TreeNode ConstructMaximumBinaryTree(int[] nums) {
        int n = nums.Count();
        return ConstructMaximumBinaryTreeUtil(0,n-1,nums);
    }
}