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
    public bool IsCousins(TreeNode root, int x, int y) {
        int[] parent = new int[101];
        int[] depth = new int[101];
        
        Queue<TreeNode> q  = new Queue<TreeNode>();
        
        q.Enqueue(root);
        parent[root.val]=0;
        depth[root.val] = 0;
        
        int level = 1;
        while(q.Count()>0)
        {
            int size = q.Count();
            while(size>0)
            {
                TreeNode temp = q.Dequeue();
                if(temp.left!=null)
                {
                    q.Enqueue(temp.left);
                    parent[temp.left.val] = temp.val;
                    depth[temp.left.val] = level; 
                }
                if(temp.right!=null)
                {
                    q.Enqueue(temp.right);
                    parent[temp.right.val] = temp.val;
                    depth[temp.right.val] = level; 
                }
                size--;
            }
            level++;
        }
        
        if(parent[x]!=parent[y] && depth[x]==depth[y])
            return true;
        return false;
        
        
    }
}