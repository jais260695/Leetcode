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
    public TreeNode Construct(int[] pre, int ei, int ej, int[] post, int ti, int tj, int n)
    {
        if(ei==ej && ti==tj) 
        {
            return new TreeNode(pre[ei]);
        }
        TreeNode root = new TreeNode(pre[ei]);
            int index = Array.IndexOf(post,pre[ei+1]); 
            int fi = ei+1;
            int fe = fi+index-ti;
            if(fi<=fe && ti<=index)
                root.left = Construct(pre,fi,fe,post,ti,index,n);
            if((fe+1)<=ej && (index+1)<=(tj-1))
                root.right = Construct(pre,fe+1,ej,post,index+1,tj-1,n);
        
        
        return root;
        
    }
    public TreeNode ConstructFromPrePost(int[] pre, int[] post) {
        int n = pre.Count();
        return Construct(pre,0,n-1,post,0,n-1,n);
        
    }
}