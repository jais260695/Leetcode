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
    public IList<double> AverageOfLevels(TreeNode root) {
        List<double> result = new List<double>();
        Queue<TreeNode> queue = new Queue<TreeNode>();
        queue.Enqueue(root);
        while(queue.Count()>0)
        {
            int size = queue.Count();
            int t = size;
            double avg = 0;
            while(size>0)
            {
                TreeNode temp = queue.Dequeue();
                avg+=temp.val;
                if(temp.left!=null)
                    queue.Enqueue(temp.left);
                if(temp.right!=null)
                    queue.Enqueue(temp.right);
                size--;
            }
            result.Add(avg/t);
        }
        return result.ToList<double>();
    }
}