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
    public IList<IList<int>> LevelOrderBottom(TreeNode root) {
        List<List<int>> result = new List<List<int>>();
        if(root==null) return result.ToList<IList<int>>();
        Queue<TreeNode> queue = new Queue<TreeNode>();
        queue.Enqueue(root);
        while(queue.Count>0)
        {
            int size = queue.Count();
            List<int> tempList = new List<int>();
            while(size>0)
            {
                TreeNode temp = queue.Dequeue();
                tempList.Add(temp.val);
                if(temp.left!=null)
                {
                    queue.Enqueue(temp.left);
                }
                if(temp.right!=null)
                {
                    queue.Enqueue(temp.right);
                }
                size--;
            }
            result.Insert(0,tempList);            
        }        
        return result.ToList<IList<int>>();
        
    }
}