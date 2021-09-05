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
    public int SumEvenGrandparent(TreeNode root) {
        Queue<TreeNode> queue = new Queue<TreeNode>();
        if(root==null) return 0;
        if(root.left==null && root.right==null) return 0;
        Dictionary<TreeNode,int> parent = new Dictionary<TreeNode,int>();
        
        if(root.left!=null)
        {
                parent[root.left] = root.val;
                queue.Enqueue(root.left);
            
        }
        
        if(root.right!=null)
        {
                parent[root.right] = root.val;
                queue.Enqueue(root.right);
        }
        int res = 0;
        while(queue.Count()>0)
        {
            int size = queue.Count();
            while(size>0)
            {
                TreeNode temp = queue.Dequeue();
                if(temp.left!=null)
                {
                    if(parent[temp]%2==0) res+=temp.left.val;
                    parent[temp.left] = temp.val;
                    queue.Enqueue(temp.left);
            
                }
                if(temp.right!=null)
                {
                    if(parent[temp]%2==0) res+=temp.right.val;
                    parent[temp.right] = temp.val;
                    queue.Enqueue(temp.right);
            
                }
                size--;
            }
        }
        return res;
    }
}