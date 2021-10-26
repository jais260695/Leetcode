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
     public TreeNode Construct(int[] pre, int ei, int ej, int[] ino, int ti, int tj, int n)
    {
        if(ei==ej && ti==tj) 
        {
            return new TreeNode(pre[ei]);
        }
        TreeNode root = new TreeNode(pre[ei]);
            int index = Array.IndexOf(ino,pre[ei]); 
            int fi = ei+1;
            int fe = fi+(index-1)-ti;
            if(fi<=fe && ti<=(index-1))
                root.left = Construct(pre,fi,fe,ino,ti,index-1,n);
            if((fe+1)<=ej && (index+1)<=(tj))
                root.right = Construct(pre,fe+1,ej,ino,index+1,tj,n);
        
        
        return root;
        
    }
    public TreeNode BuildTree(int[] pre, int[] ino) {
        int n = pre.Count();
        if(n==0) return null;
        return Construct(pre,0,n-1,ino,0,n-1,n);
    }
}