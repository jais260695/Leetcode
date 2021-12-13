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
        if(ei==ej) 
        {
            return new TreeNode(pre[ei]);
        }
        TreeNode root = new TreeNode(pre[ei]);
            int index = Array.IndexOf(ino,pre[ei]); 
            int i = ei+1;
            int lengthLeftSubtree = index-ti;
            int j = ei+lengthLeftSubtree;
            
            if(i<=j && ti<=(index-1))
                root.left = Construct(pre,i,j,ino,ti,index-1,n);
         
            int lengthRightSubtree = tj-index;
         
            if((j+1)<=ej && (index+1)<=(tj))
                root.right = Construct(pre,j+1,ej,ino,index+1,tj,n);
        
        
        return root;
        
    }
    public TreeNode BuildTree(int[] pre, int[] ino) {
        int n = pre.Count();
        if(n==0) return null;
        return Construct(pre,0,n-1,ino,0,n-1,n);
    }
}