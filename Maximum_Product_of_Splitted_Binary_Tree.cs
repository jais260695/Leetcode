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
    int mod = 1000000007;
    Dictionary<TreeNode, long> map= new Dictionary<TreeNode, long>();
    public long DFSFindSum(TreeNode root)
    {
        if(root==null) return  0 ;
        map.Add(root,root.val + DFSFindSum(root.left) + DFSFindSum(root.right));
        return map[root];
    }

    public long MaximumProduct(TreeNode root, long totalSum)
    {
        if(root==null) return 0;
        long leftSum = root.left == null ? 0 :  map[root.left];
        long rightSum = root.right == null ? 0 : map[root.right];
        return Math.Max(
            Math.Max(leftSum*(totalSum-leftSum),rightSum*(totalSum-rightSum)),
            Math.Max(MaximumProduct(root.left,totalSum),MaximumProduct(root.right,totalSum))
        );
    }

    public int MaxProduct(TreeNode root) {
        long totalSum = DFSFindSum(root);

        return (int)(MaximumProduct(root,totalSum)%mod);
    }
}