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
    public int MaxLevelSum(TreeNode root) {
        if(root==null) return 0;
        Queue<TreeNode> queue = new Queue<TreeNode>();
        queue.Enqueue(root);
        int level = 1;
        int maxSum = int.MinValue;
        int result = 0;
        while(queue.Count()>0)
        {
            int size = queue.Count();
            int sum = 0;
            while(size>0)
            {
                TreeNode temp = queue.Dequeue();
                sum+=temp.val;
                if(temp.left!=null) queue.Enqueue(temp.left);
                if(temp.right!=null) queue.Enqueue(temp.right);
                size--;
            }
            if(maxSum<sum)
            {
                maxSum = sum;
                result = level;
            }
            level++;
        }
        return result;
    }
}