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
    public bool Compare(TreeNode t1, TreeNode t2)
    {
        if(t1==null && t2==null) return true;
        if(t1==null || t2==null) return false;
        if(t1.val==t2.val)
        {
            if(Compare(t1.left, t2.left))
            {
               return Compare(t1.right, t2.right);
            }
        }
        return false;
    }
    public bool IsSubtree(TreeNode root, TreeNode subRoot) {
        Queue<TreeNode> queue = new Queue<TreeNode>();
        queue.Enqueue(root);        
        while(queue.Count()>0)
        {
            TreeNode t = queue.Dequeue();
            if(t.val==subRoot.val)
            {
                if(Compare(t,subRoot)) return true;
            }
            if(t.left!=null) queue.Enqueue(t.left);
            if(t.right!=null) queue.Enqueue(t.right);
        }
        return false;
    }
}