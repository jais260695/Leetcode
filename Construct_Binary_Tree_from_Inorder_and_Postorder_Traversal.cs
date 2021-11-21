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
     public TreeNode Construct(int[] post, int ei, int ej, int[] ino, int ti, int tj, int n)
    {
        if(ei==ej && ti==tj) 
        {
            return new TreeNode(post[ei]);
        }
        TreeNode root = new TreeNode(post[ej]);
            int index = Array.IndexOf(ino,post[ej]); 
            int fi = ei;
            int fe = fi+(index-1)-ti;
            if(fi<=fe && ti<=(index-1))
                root.left = Construct(post,fi,fe,ino,ti,index-1,n);
            if((fe+1)<=(ej-1) && (index+1)<=tj)
                root.right = Construct(post,fe+1,ej-1,ino,index+1,tj,n);
        
        
        return root;
        
    }
    public TreeNode BuildTree(int[] inorder, int[] postorder) {
        int n = inorder.Count();
        if(n==0) return null;
        return Construct(postorder,0,n-1,inorder,0,n-1,n);
    }
}