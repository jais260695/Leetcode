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
    public TreeNode AddOneRow(TreeNode root, int v, int d) {
        if(d==1)
        {
            TreeNode newNode = new TreeNode(v);
            newNode.left = root;
            return newNode;
        }
        
        Queue<TreeNode> queue = new Queue<TreeNode>();
        queue.Enqueue(root);
        int level = 1;
        while(queue.Count()>0)
        {
            level++;
            if(level==d) break;
            int size = queue.Count();
            while(size>0)
            {
                TreeNode temp = queue.Dequeue();
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
        }
        while(queue.Count()>0)
        {
            TreeNode temp = queue.Dequeue();
            TreeNode tLeft = temp.left;
            TreeNode tRight = temp.right;
            temp.left = new TreeNode(v);
            temp.right = new TreeNode(v);     
            temp.left.left = tLeft;
            temp.right.right = tRight;
        }
        
        return root;
    }
}